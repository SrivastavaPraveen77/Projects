using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using MGA.BASE.Home;
using MGAChargerEcommerce.Models;
using MGAChargerEcommerece.Helper;
using System.Configuration;
using System.Text;
using System.Security.Cryptography;

namespace MGAChargerEcommerce.Controllers
{
	public class ShopController : Controller
	{
		//
		// GET: /Shop/
		MGA.Base.ActionResult actionResult = new MGA.Base.ActionResult();
        MGA.Base.ActionResult actionResult1 = new MGA.Base.ActionResult();
		MGA.ActionLayer.Home.HomeAL homeAction = new MGA.ActionLayer.Home.HomeAL();

		#region Declaration

		MGA.ActionLayer.Account.AccountAction accountAction = new MGA.ActionLayer.Account.AccountAction();
		MGA.ActionLayer.Admin.AdminAL adminAction = new MGA.ActionLayer.Admin.AdminAL();
		#endregion

		string action1 = string.Empty;
		string hash1 = string.Empty;
		string txnid1 = string.Empty;
        decimal shippingCharges = 0;
        int qty_New = 0;

		//
		// GET: /Store/Details
		public ActionResult Index(int id = 1)
		{
			ProductBase baseModel = new ProductBase();
			ManageProduct model = new ManageProduct();
			List<ManageProduct> productList = new List<ManageProduct>();
			baseModel.ProductId = 0;
			baseModel.ProductCategory = id;
			baseModel.ActionId = 4;
			actionResult = homeAction.get_Products(baseModel);

			if (actionResult.IsSuccess)
			{
				productList = Helper.ConvertTo<ManageProduct>(actionResult.dtResult);
			}
			model.ManageProductlist = productList;
			return View(model);
		}

		public ActionResult Details(int Id = 1)
		{
			ProductBase baseModel = new ProductBase();
			ManageProduct model = new ManageProduct();
			List<ManageProduct> productList = new List<ManageProduct>();
			baseModel.ProductId = Id;
			baseModel.ActionId = 1;
			actionResult = homeAction.get_Products(baseModel);

			if (actionResult.IsSuccess)
			{
				productList = Helper.ConvertTo<ManageProduct>(actionResult.dtResult);
			}
			model.ManageProductlist = productList;
			return View(model);
		}

		[HttpGet]
		public ActionResult GetPrductavailabilityBypincode(String Pincode)
		{
			actionResult = homeAction.get_PrductavailabilityBypincode(Pincode);

			string jsonString = string.Empty;
			if (actionResult.dtResult.Rows.Count > 0)
			{
				//jsonString = "{\"Status\":\"1\"}";
				jsonString = "{\"Status\":\"1\"}";
			}
			else
			{
				jsonString = "{\"Status\":\"-1\"}";
			}
			return Json(jsonString, JsonRequestBehavior.AllowGet);
		}


		public ActionResult Cart()
		{
           
			return View(new TempCartFunctions());
		}

		[HttpGet]
		public ActionResult CheckOut()
		
        {

			MGA.ActionLayer.Admin.AdminAL adminAction = new MGA.ActionLayer.Admin.AdminAL();
			ProceedCheckOut objProceedCheckOut = new ProceedCheckOut();
			TempCartFunctions obj = new TempCartFunctions();
			CheckoutModel chkOutModel = new CheckoutModel();


            TempCartFunctions objTempCartFunctions = new TempCartFunctions();
            List<TempCartClass> tempCarts = objTempCartFunctions.GetCartProducts();

            //SelectList stateList = new SelectList();
            actionResult = adminAction.getState();
            var state= actionResult.dtResult.AsEnumerable().Select(v => new SelectListItem { Text = v["StateName"].ToString(), Value = v["Id"].ToString() }).ToList();

            //TempData["Qty"] = tempCarts[0].Qty; 08 April 20019
            TempData["Qty"] = 0;

			objProceedCheckOut.tempCarrtFunction = obj;
			objProceedCheckOut.checkOutModel = chkOutModel;
            for (int i = 0; i < tempCarts.Count; i++)
            {
                TempData["Qty"] =Convert.ToInt32(TempData["Qty"])+tempCarts[i].Qty;

            }
			//Get login detail code  (not working)
			List<CheckoutModel> chkList = new List<CheckoutModel>();
			if (Session["userName"] != null)
			{
				CheckoutBase baseModel = new CheckoutBase();
				CheckoutModel model = new CheckoutModel();

				baseModel.UserId = Convert.ToInt32(Session["userId"].ToString());
				baseModel.Action = 1;
				actionResult = homeAction.get_UserAddress(baseModel);

				if (actionResult.IsSuccess)
				{
					chkList = Helper.ConvertTo<CheckoutModel>(actionResult.dtResult);
				}
				objProceedCheckOut.checkOutModel.Checkoutlist = chkList;

                //SelectList stateList = new SelectList(state,"Value","Text", chkList[0].BState);
                //ViewBag.stateListList = stateList;
            }


			//Get Shipping charges code  (not working)
			CheckoutBase baseModel1 = new CheckoutBase();
			CheckoutModel model1 = new CheckoutModel();
			List<CheckoutModel> chkList1 = new List<CheckoutModel>();

			if (chkList.Count !=0 )
			{
				if (chkList[0].BPinCode != null)
					baseModel1.DPinCode = chkList[0].BPinCode;

				baseModel1.Action = 2;
				actionResult = homeAction.get_UserAddress(baseModel1);

				if (actionResult.IsSuccess)
				{
					//objProceedCheckOut.checkOutModel.Checkoutlist[0].Shipingcharges = Helper.ConvertTo<CheckoutModel>(actionResult.dtResult.Rows[0]["ShippingCharges"]);
					objProceedCheckOut.checkOutModel.Checkoutlist[0].Shipingcharges = Convert.ToDecimal(actionResult.dtResult.Rows[0]["ShippingCharges"]);
                    shippingCharges = Convert.ToDecimal(objProceedCheckOut.checkOutModel.Checkoutlist[0].Shipingcharges) * Convert.ToInt32(TempData["Qty"]);
				}
			}
			
			/////////////////

			return View(objProceedCheckOut);


			//return View(new TempCartFunctions());
		}



		[HttpPost]
		public ActionResult CheckOut(ProceedCheckOut model, FormCollection fc)
		{
			TempCartFunctions tempCartFunctions = new TempCartFunctions();

            var coupon = "";
			if (tempCartFunctions.CountCart() > 0)
			{
				// generating txnid
				Random rnd = new Random();
				string strHash = Generatehash512(rnd.ToString() + DateTime.Now);
				txnid1 = strHash.ToString().Substring(0, 20);


				CheckoutBase checkoutBase = new CheckoutBase();
				checkoutBase.Action = 1;
				checkoutBase.TxId = txnid1;
				checkoutBase.UserId = Convert.ToInt32(Session["userId"].ToString());
				checkoutBase.TotalOrderAmount = tempCartFunctions.GetTotal();
				checkoutBase.DiscountAmount = 0;
				checkoutBase.CODCharges = 0;
				checkoutBase.GrandTotalAmount = tempCartFunctions.GetTotal();
				checkoutBase.PaymentMode = 1;
				checkoutBase.VAT = 0;
				checkoutBase.ServiceTax = 0;
				checkoutBase.AWBNumber = "";
                CheckoutBase baseModel1 = new CheckoutBase();
                baseModel1.Action = 2;
                
                if (model.checkOutModel.Checkoutlist != null && model.checkOutModel.Checkoutlist.Count>0)
                {
                    checkoutBase.BName = model.checkOutModel.Checkoutlist[0].BName;
                    checkoutBase.BEmail = model.checkOutModel.Checkoutlist[0].BEmail;
                    checkoutBase.BPhoneNo = model.checkOutModel.Checkoutlist[0].BMobileNo;
                    checkoutBase.BState = model.checkOutModel.Checkoutlist[0].BState;
                    checkoutBase.BCity = Convert.ToString(fc["selectedbillingcityId"]);
                    checkoutBase.BAddress = model.checkOutModel.Checkoutlist[0].BAddress;
                    checkoutBase.BPinCode = model.checkOutModel.Checkoutlist[0].BPinCode;

                    checkoutBase.DName = model.checkOutModel.Checkoutlist[0].DName;
                    checkoutBase.DEmail = model.checkOutModel.Checkoutlist[0].DEmail;
                    checkoutBase.DPhoneNo = model.checkOutModel.Checkoutlist[0].DMobileNo;
                    checkoutBase.DState = model.checkOutModel.Checkoutlist[0].DState;
                    checkoutBase.DCity = Convert.ToString(fc["selectedDeliverycityId"]);
                    checkoutBase.DAddress = model.checkOutModel.Checkoutlist[0].DAddress;
                    checkoutBase.DPinCode = model.checkOutModel.Checkoutlist[0].DPinCode;
                    baseModel1.DPinCode = model.checkOutModel.Checkoutlist[0].DPinCode;

                }
                else
                {
                    checkoutBase.BName = model.checkOutModel.BName;
                    checkoutBase.BEmail = model.checkOutModel.BEmail;
                    checkoutBase.BPhoneNo = model.checkOutModel.BMobileNo;
                    checkoutBase.BState = model.checkOutModel.BState;
                    checkoutBase.BCity = Convert.ToString(fc["selectedbillingcityId"]);
                    checkoutBase.BAddress = model.checkOutModel.BAddress;
                    checkoutBase.BPinCode = model.checkOutModel.BPinCode;

                    checkoutBase.DName = model.checkOutModel.DName;
                    checkoutBase.DEmail = model.checkOutModel.DEmail;
                    checkoutBase.DPhoneNo = model.checkOutModel.DMobileNo;
                    checkoutBase.DState = model.checkOutModel.DState;
                    checkoutBase.DCity = Convert.ToString(fc["selectedDeliverycityId"]);
                    checkoutBase.DAddress = model.checkOutModel.DAddress;
                    checkoutBase.DPinCode = model.checkOutModel.DPinCode;
                    baseModel1.DPinCode = model.checkOutModel.DPinCode;
                }

				
				checkoutBase.TransactionStatus = "0";
                actionResult1 = homeAction.get_UserAddress(baseModel1);

                TempCartFunctions objTempCartFunctions = new TempCartFunctions();
                List<TempCartClass> tempCarts = objTempCartFunctions.GetCartProducts();

                for (int i = 0; i < tempCarts.Count; i++)
                {
                    TempData["Qty"] = Convert.ToInt32(TempData["Qty"]) + tempCarts[i].Qty;

                }

                shippingCharges = Convert.ToDecimal(actionResult1.dtResult.Rows[0]["ShippingCharges"].ToString()) * Convert.ToInt32(TempData["Qty"]);
                #region coupon
                coupon = model.checkOutModel.CouponCode;
                var userId = Convert.ToInt32(Session["userId"]);
                var coupnResult = adminAction.getCouponDetails(coupon, userId);
                List<CustomerCoupon> CustomerCouponlist = new List<CustomerCoupon>();
                CustomerCouponlist = Helper.ConvertTo<CustomerCoupon>(coupnResult.dtResult);
                checkoutBase.CouponCode = coupon;
                decimal discount = 0m;
                if (CustomerCouponlist.Count>0)
                {
                    var MinPurchaseAmount = Convert.ToDecimal( CustomerCouponlist[0].MinPurchaseAmount ?? 0);
                   if ( CustomerCouponlist[0].ExpiredOn >= DateTime.Now.Date && (MinPurchaseAmount <= checkoutBase.TotalOrderAmount || MinPurchaseAmount==0))
                    {
                       
                        if (CustomerCouponlist[0].DiscountType=="P")
                        {
                            if (CustomerCouponlist[0].Discount != 0)
                                discount = Convert.ToDecimal(checkoutBase.TotalOrderAmount * CustomerCouponlist[0].Discount / 100);
                            else
                                discount = 0;
                        }
                        else
                        {
                            discount = CustomerCouponlist[0].Discount ?? 0 ;

                        }
                        checkoutBase.DiscountAmount = discount;
                        checkoutBase.GrandTotalAmount = checkoutBase.TotalOrderAmount- discount;
                    }

                }

                #endregion
                actionResult = homeAction.SaveOrder(checkoutBase);
				if (actionResult.IsSuccess)
				{
					if (Convert.ToInt32(actionResult.dsResult.Tables[0].Rows[0][0].ToString()) > 0)
					{
						int orderid = Convert.ToInt32(actionResult.dsResult.Tables[0].Rows[0]["OrderId"].ToString());
						string orderno = actionResult.dsResult.Tables[0].Rows[0]["OrderNumber"].ToString();

						if (SaveOrderDetail(orderid) == 1)
						{
							Session["orderid"] = orderid;
							Session["orderno"] = orderno;
                            if (model.checkOutModel.Checkoutlist != null && model.checkOutModel.Checkoutlist.Count > 0)
                            {
                                MakePayment(tempCartFunctions.GetTotal()+shippingCharges-discount, model.checkOutModel.Checkoutlist[0].DName, model.checkOutModel.Checkoutlist[0].DEmail,
                                    model.checkOutModel.Checkoutlist[0].DMobileNo, "product info", model.checkOutModel.Checkoutlist[0].DAddress,
                                    "15", "Uttar Pradesh", model.checkOutModel.Checkoutlist[0].DPinCode);
                            }
                            else
                            {
                                MakePayment(tempCartFunctions.GetTotal() + shippingCharges - discount, model.checkOutModel.DName, model.checkOutModel.DEmail,
                                      model.checkOutModel.DMobileNo, "product info", model.checkOutModel.DAddress,
                                      "15", "Uttar Pradesh", model.checkOutModel.DPinCode);
                            }

						}
						else
						{
							TempData["COErrorMessage"] = "Some error occurred. Please try again later.";
							return RedirectToAction("CheckOut", "Shop");
						}
					}
					else
					{
						TempData["COErrorMessage"] = "Some error occurred. Please try again later.";
						return RedirectToAction("CheckOut", "Shop");
					}
				}
			}
			else
			{
				return RedirectToAction("CheckOut", "Shop");
			}

			return View(model);
		}

		private int SaveOrderDetail(int OrderId)
		{
			int countResult = 0, value = 0;
			TempCartFunctions tempCartFunctions = new TempCartFunctions();
			if (tempCartFunctions.CountCart() > 0)
			{
				CheckoutProductBase checkoutProductBase = new CheckoutProductBase();

				foreach (var item in tempCartFunctions.GetCartProducts())
				{
					checkoutProductBase.Action = 1;
					checkoutProductBase.OrderId = OrderId;
					checkoutProductBase.ProductId = item.ProductId;
					checkoutProductBase.Quantity = item.Qty;
					checkoutProductBase.PerPrice = item.PerPrice;
					checkoutProductBase.TotalPrice = item.PriceQty;

					actionResult = homeAction.SaveOrderDetail(checkoutProductBase);
					if (actionResult.IsSuccess)
					{
						if (Convert.ToInt32(actionResult.dsResult.Tables[0].Rows[0][0].ToString()) > 0)
							countResult++;
					}
				}

				if (countResult == tempCartFunctions.CountCart())
					value = 1;
				else
					value = 0;
			}
			else
				value = 0;

			return value;
		}

		private void MakePayment(decimal amount, string name, string email, string phone, string productinfo, string address, string city, string state, string zipcode)
		{
			try
			{

				//	MakePayment(5000, "DName1", "DEmail@gmailcom", "123456789",
				//"product info", "DAddress 1", "2", "DState1", "147852");

				string keyValue = ConfigurationManager.AppSettings["MERCHANT_KEY"];

				if (string.IsNullOrEmpty(ConfigurationManager.AppSettings["MERCHANT_KEY"]) || string.IsNullOrEmpty(txnid1))
				{
					//error
					return;
				}


				RemotePost myremotepost = new RemotePost();

				myremotepost.Url = ConfigurationManager.AppSettings["PAYU_BASE_URL"] + "/_payment";
				myremotepost.Add("txnid", txnid1);
				myremotepost.Add("key", keyValue);
				string AmountForm = amount.ToString("g29");// eliminating trailing zeros
				myremotepost.Add("amount", AmountForm);
				myremotepost.Add("firstname", name);
				myremotepost.Add("email", email);
				myremotepost.Add("phone", phone);
				myremotepost.Add("productinfo", productinfo);
				myremotepost.Add("surl", ConfigurationManager.AppSettings["PAYU_SUCCESS_URL"]);
				myremotepost.Add("furl", ConfigurationManager.AppSettings["PAYU_FAILURE_URL"]);
				myremotepost.Add("lastname", "");
				myremotepost.Add("curl", ConfigurationManager.AppSettings["PAYU_CANCEL_URL"]);
				myremotepost.Add("address1", address);
				myremotepost.Add("address2", "");
				myremotepost.Add("city", city);
				myremotepost.Add("state", state);
				myremotepost.Add("country", "India");
				myremotepost.Add("zipcode", zipcode);
                myremotepost.Add("service_provider","payu_paisa");


				string hashString = keyValue + "|" + txnid1 + "|" + AmountForm + "|" + productinfo + "|" + name + "|" + email + "|||||||||||" + ConfigurationManager.AppSettings["SALT"];
				string hash = Generatehash512(hashString);
				myremotepost.Add("hash", hash);
				myremotepost.Post();

			}
			catch (Exception ex)
			{
				Response.Write("<span style='color:red'>" + ex.Message + "</span>");

			}
		}


		public string Generatehash512(string text)
		{

			byte[] message = Encoding.UTF8.GetBytes(text);

			UnicodeEncoding UE = new UnicodeEncoding();
			byte[] hashValue;
			SHA512Managed hashString = new SHA512Managed();
			string hex = "";
			hashValue = hashString.ComputeHash(message);
			foreach (byte x in hashValue)
			{
				hex += String.Format("{0:x2}", x);
			}
			return hex;

		}

		public class RemotePost
		{
			private System.Collections.Specialized.NameValueCollection Inputs = new System.Collections.Specialized.NameValueCollection();


			public string Url = "";
			public string Method = "post";
			public string FormName = "form1";

			public void Add(string name, string value)
			{
				Inputs.Add(name, value);
			}

			public void Post()
			{
				System.Web.HttpContext.Current.Response.Clear();

				System.Web.HttpContext.Current.Response.Write("<html><head>");

				System.Web.HttpContext.Current.Response.Write(string.Format("</head><body onload=\"document.{0}.submit()\">", FormName));
				System.Web.HttpContext.Current.Response.Write(string.Format("<form name=\"{0}\" method=\"{1}\" action=\"{2}\" >", FormName, Method, Url));
				for (int i = 0; i < Inputs.Keys.Count; i++)
				{
					System.Web.HttpContext.Current.Response.Write(string.Format("<input name=\"{0}\" type=\"hidden\" value=\"{1}\">", Inputs.Keys[i], Inputs[Inputs.Keys[i]]));
				}
				System.Web.HttpContext.Current.Response.Write("</form>");
				System.Web.HttpContext.Current.Response.Write("</body></html>");

				System.Web.HttpContext.Current.Response.End();
			}
		}

		public ActionResult AddToCart_Index(int id, string productname, Int16 qty, decimal productRate, string productImage)
		{
			AddUpdate_ItemsOnCart(id, productname, qty, productRate, productImage);
			return RedirectToAction("Cart");
		}

		public ActionResult AddToCart(int id, string productname, Int16 qty, decimal productRate, string productImage)
		{
			AddUpdate_ItemsOnCart(id, productname, qty, productRate, productImage);
			var urlBuilder = new UrlHelper(Request.RequestContext);
			var url = urlBuilder.Action("Cart", "Shop");
			return Json(new { status = "success", redirectUrl = url });
		}

		public ActionResult BuyNow_Details(int id, string productname, Int16 qty, decimal productRate, string productImage)
		{
            //productRate = productRate * qty;
			AddUpdate_ItemsOnCart(id, productname, qty, productRate, productImage);
            var urlBuilder = new UrlHelper(Request.RequestContext);
            var url = urlBuilder.Action("CheckOut", "Shop");
            return Json(new { status = "success", redirectUrl = url });
            //return RedirectToAction("CheckOut");
		}


		[HttpGet]
		public JsonResult City_Bind(int id)
		{
			actionResult = adminAction.getCity(id);
			List<SelectListItem> citylist = new List<SelectListItem>();
			citylist = actionResult.dtResult.AsEnumerable().Select(v => new SelectListItem { Text = v["CityName"].ToString(), Value = v["Id"].ToString() }).ToList();
			return Json(citylist, JsonRequestBehavior.AllowGet);
		}


		[HttpGet]
		public JsonResult GetShippingCharges(int id)
		{
			actionResult = adminAction.getCity(id);
			List<SelectListItem> citylist = new List<SelectListItem>();
			citylist = actionResult.dtResult.AsEnumerable().Select(v => new SelectListItem { Text = v["CityName"].ToString(), Value = v["Id"].ToString() }).ToList();
			return Json(citylist, JsonRequestBehavior.AllowGet);
		}

		public ActionResult RemoveFromCart(int id)
		{
			TempCartFunctions objTempCartFunction = new TempCartFunctions();
			objTempCartFunction.DeleteItemFromCart(id);
			return RedirectToAction("Cart");
		}

		public ActionResult OrderComplete()
		{
            TempCartFunctions objTempCartFunctions = new TempCartFunctions();
            List<TempCartClass> tempCarts = objTempCartFunctions.GetCartProducts();

            TempData["Qty"] = 0;

            for (int i = 0; i < tempCarts.Count; i++)
            {
                TempData["Qty"] = Convert.ToInt32(TempData["Qty"]) + tempCarts[i].Qty;
            }

			return View(new TempCartFunctions());
		}

		public ActionResult TransactionCancelled()
		{
			return View(new TempCartFunctions());
		}

		public ActionResult OrderFailure()
		{
			return View(new TempCartFunctions());
		}
		public ActionResult OrderCancel()
		{
			return View();
		}


		private void AddUpdate_ItemsOnCart(int productId, string itemName, Int16 qty, decimal price, string productImage)
		{
			TempCartFunctions objTempCartFunctions = new TempCartFunctions();
			List<TempCartClass> cartProducts = objTempCartFunctions.GetCartProducts();
			if (cartProducts.Count > 0)
			{
				TempCartClass objCartItem = cartProducts.Where(cp => cp.ProductName == itemName).FirstOrDefault();
				if (objTempCartFunctions == null)
				{
					//Response.Redirect("ErrorPage.aspx?mid=gd");
				}
				if (objCartItem == null)
				{
					// add
					TempCartFunctions objCartFunctions = new TempCartFunctions();
					TempCartClass objTempCartClass = new TempCartClass
					{
						ProductName = itemName,
						ProductId = productId,
						Qty = qty,
						PerPrice = price,
						ProductImage = productImage,
						PriceQty = price * qty
					};

					objCartFunctions.SetCartInSession(objTempCartClass);

				}
				else
				{
					TempCartClass objTempCartClass = new TempCartClass
					{
						ProductName = itemName,
						ProductId = productId,
						Qty = qty,
						PerPrice = price,
						ProductImage = productImage,
						PriceQty = price * qty
					};
					objTempCartFunctions.UpdateCartInSession(objTempCartClass);
				}
			}
			else
			{
				// add
				TempCartFunctions objCartFunctions = new TempCartFunctions();
				TempCartClass objTempCartClass = new TempCartClass
				{
					ProductName = itemName,
					ProductId = productId,
					Qty = qty,
					PerPrice = price,
					ProductImage = productImage,
					PriceQty = price * qty
				};

				objCartFunctions.SetCartInSession(objTempCartClass);
			}
		}

		public ActionResult View1dsd()
		{
			return View();
		}
	}
}
