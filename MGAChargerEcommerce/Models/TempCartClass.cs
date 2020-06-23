using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MGAChargerEcommerce.Models
{
    public class TempCartClass
    {
        public TempCartClass()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public Int16 Qty { get; set; }
        public decimal PerPrice { get; set; }
        public decimal PriceQty { get; set; }
    }


    public class TempCartAddressPaymentMode
    {
        public string ShippingAddressLine1 { get; set; }
        public string ShippingAddressLine2 { get; set; }
        public int ShippingCountryId { get; set; }
        public int ShippingStateId { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingPincode { get; set; }
        public string ShippingContact { get; set; }
        public string ShippingEmail { get; set; }

        public string ShippingFirstName { get; set; }
        public string ShippingLastName { get; set; }
    }

    public class CartViewModel
    {
        public List<TempCartClass> tempCartClass { get; set; }
    }

    public class ProceedCheckOut
    {
        public TempCartFunctions tempCarrtFunction { get; set; }

        public CheckoutModel checkOutModel { get; set; }
        
    }

    public class TempCartFunctions
    {
        public void SetCartInSession(TempCartClass objTempCart)
        {
            List<TempCartClass> tempCarts = GetCartProducts();
           
            tempCarts.Add(objTempCart);
            HttpContext.Current.Session["TempCartProducts"] = tempCarts;
        }

        public void ClearCartSession()
        {
            HttpContext.Current.Session["TempCartProducts"] = null;
            HttpContext.Current.Session["TempCartAddress"] = null;
        }

        public List<TempCartClass> GetCartProducts()
        {
            List<TempCartClass> tempCarts = new List<TempCartClass>();
            //HttpContext.Current.Session["TempCartProducts"];
            if (!string.IsNullOrEmpty(Convert.ToString(HttpContext.Current.Session["TempCartProducts"])))
            {
                tempCarts = (List<TempCartClass>)HttpContext.Current.Session["TempCartProducts"];
            }

            return tempCarts;
        }

        public int CountCart()
        {
            TempCartFunctions objTempCartFunctions = new TempCartFunctions();
            TempCartClass objTempCart = new TempCartClass();
            List<TempCartClass> tempCarts = objTempCartFunctions.GetCartProducts();
            int? count = tempCarts.Count;
            return count ?? 0;
        }

        public decimal GetTotal()
        {
            decimal PriceValue = 0;
            TempCartFunctions objTempCartFunctions = new TempCartFunctions();
            TempCartClass objTempCart = new TempCartClass();
            List<TempCartClass> tempCarts = objTempCartFunctions.GetCartProducts();
            if (tempCarts.Count > 0)
            {
                foreach (var prime in tempCarts)
                {
                    PriceValue = PriceValue + prime.PriceQty;
                }
            }

            decimal? total = PriceValue;
            return total ?? decimal.Zero;
        }

		public decimal GetFinalTotal(decimal ShippingCharges)
		{
			decimal PriceValue = 0;
			TempCartFunctions objTempCartFunctions = new TempCartFunctions();
			TempCartClass objTempCart = new TempCartClass();
			List<TempCartClass> tempCarts = objTempCartFunctions.GetCartProducts();
			if (tempCarts.Count > 0)
			{
				foreach (var prime in tempCarts)
				{
					PriceValue = PriceValue + prime.PriceQty;
				}
			}

			if (PriceValue > 0)
				PriceValue = PriceValue + ShippingCharges;

			decimal? total = PriceValue;
			return total ?? decimal.Zero;
		}

        public decimal GetOrderCompleteFinalTotal(decimal ShippingCharges,decimal TotalAmount)
        {
            decimal? total = ShippingCharges+TotalAmount;
            return total ?? decimal.Zero;
        }


		public void UpdateCartInSession(TempCartClass tempCart)
        {
            List<TempCartClass> tempCarts = new List<TempCartClass>();
            if (!string.IsNullOrEmpty(Convert.ToString(HttpContext.Current.Session["TempCartProducts"])))
            {
                tempCarts = (List<TempCartClass>)HttpContext.Current.Session["TempCartProducts"];
                TempCartClass objTempCart = tempCarts.Where(tc => tc.ProductName == tempCart.ProductName).FirstOrDefault();
                if (objTempCart != null)
                {
                    objTempCart.ProductName = tempCart.ProductName;
                    objTempCart.PerPrice = tempCart.PerPrice;
                    objTempCart.PriceQty = tempCart.PriceQty;
                    objTempCart.ProductImage = tempCart.ProductImage;
                    objTempCart.Qty = tempCart.Qty;
                }
            }
            else
            {
                tempCarts.Add(tempCart);
            }
            HttpContext.Current.Session["TempCartProducts"] = tempCarts;
        }

        public void DeleteItemFromCart(int ProductId)
        {
            List<TempCartClass> tempCarts = new List<TempCartClass>();
            if (!string.IsNullOrEmpty(Convert.ToString(HttpContext.Current.Session["TempCartProducts"])))
            {
                tempCarts = (List<TempCartClass>)HttpContext.Current.Session["TempCartProducts"];
                TempCartClass objTempCart = tempCarts.Where(tc => tc.ProductId == ProductId).FirstOrDefault();
                if (objTempCart != null)
                    tempCarts.Remove(objTempCart);
            }
            HttpContext.Current.Session["TempCartProducts"] = tempCarts;
        }

        public void SetBillingDetailsInSession(TempCartAddressPaymentMode tempAddress)
        {
            TempCartAddressPaymentMode objTempCartAddress = new TempCartAddressPaymentMode();

            objTempCartAddress.ShippingAddressLine1 = tempAddress.ShippingAddressLine1;
            objTempCartAddress.ShippingAddressLine2 = tempAddress.ShippingAddressLine2;
            objTempCartAddress.ShippingCountryId = tempAddress.ShippingCountryId;
            objTempCartAddress.ShippingStateId = tempAddress.ShippingStateId;
            objTempCartAddress.ShippingCity = tempAddress.ShippingCity;
            objTempCartAddress.ShippingPincode = tempAddress.ShippingPincode;
            objTempCartAddress.ShippingEmail = tempAddress.ShippingEmail;

            objTempCartAddress.ShippingFirstName = tempAddress.ShippingFirstName;
            objTempCartAddress.ShippingLastName = tempAddress.ShippingLastName;

            objTempCartAddress.ShippingContact = tempAddress.ShippingContact;
            HttpContext.Current.Session["TempCartAddress"] = objTempCartAddress;
        }

        public TempCartAddressPaymentMode GetBillingDetailsInSession()
        {
            if (!string.IsNullOrEmpty(Convert.ToString(HttpContext.Current.Session["TempCartAddress"])))
            {
                return ((TempCartAddressPaymentMode)HttpContext.Current.Session["TempCartAddress"]);
            }
            else
                return null;
        }
    }

    public class CheckoutModel
    {
		[Display(Name = "Enter Name Here")]
		[Required(ErrorMessage = "Name is Required.")]
		public string BName { get; set; }

		[Display(Name = "Mobile No")]
		[Required(ErrorMessage = "Mobile No is Required.")]
		public string BMobileNo { get; set; }

        public decimal Shipingcharges { get; set; }
        public string BPhoneNo { get; set; }


		[Display(Name = "Enter Email Here")]
		[Required(ErrorMessage = "Email required.")]
		[RegularExpression(".+@.+\\..+", ErrorMessage = "Email not valid.")]
		public string BEmail { get; set; }

		[Display(Name = "State")]
		[Required(ErrorMessage = "State is Required.")]
		public string BState { get; set; }

		[Display(Name = "City")]
		[Required(ErrorMessage = "City is Required.")]
		public string BCity { get; set; }

        [Display(Name = "BILLING ADDRESS / GST NO(IF ANY)")]
		[Required(ErrorMessage = "Billing Address is Required.")]
		public string BAddress { get; set; }

		[Display(Name = "PinCode")]
        [RegularExpression(@"^\d{3}\s?\d{3}$", ErrorMessage = "Invalid PinCode")]
        [Required(ErrorMessage = "PinCode is Required.")] 
		public string BPinCode { get; set; }

		[Display(Name = "Enter Name Here")]
		[Required(ErrorMessage = "Name is Required.")]
		public string DName { get; set; }

		[Display(Name = "Mobile No")]
		[Required(ErrorMessage = "Mobile No is Required.")]
		public string DMobileNo { get; set; }

		[Display(Name = "Enter Email Here")]
		[Required(ErrorMessage = "Email required.")]
		[RegularExpression(".+@.+\\..+", ErrorMessage = "Email not valid.")]
		public string DEmail { get; set; }

		[Display(Name = "State")]
		[Required(ErrorMessage = "State is Required.")]
		public string DState { get; set; }

		[Display(Name = "City")]
		[Required(ErrorMessage = "City is Required.")]
		public string DCity { get; set; }

        [Display(Name = "ENTER GST NO(IF ANY) / DELIVERY ADDRESS")]
		[Required(ErrorMessage = "Delivery Address is Required.")]
		public string DAddress { get; set; }

		[Display(Name = "PinCode")]
		[RegularExpression(@"^\d{3}\s?\d{3}$", ErrorMessage = "Invalid PinCode")]
		[Required(ErrorMessage = "PinCode is Required.")]
		public string DPinCode { get; set; }




		[Display(Name = "Total Amount")]
		public decimal TotalAmount { get; set; }


        public List<CheckoutModel> Checkoutlist { get; set; }

		


		//[Display(Name = "Contact Number")]
  //      [Required(ErrorMessage = "Delivery Contact is Required.")]

  //      [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Numeric Numbers are Allowed Only.")]
  //      [StringLength(10, ErrorMessage = "The {0} must be 10 Digit.", MinimumLength = 10)]

        [Display(Name = "Coupon")]
        public string CouponCode { get; set; }
        public string DiscountType { get; set; }
        public decimal? Discount{ get; set; }

        public decimal? MinPurchaseAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? beforeDiscountTotalAmount { get; set; }
        public string Company { get; set; }

        public List<System.Web.Mvc.SelectListItem> citylist { get; set; }
        public List<System.Web.Mvc.SelectListItem> statelist { get; set; }

        public List<System.Web.Mvc.SelectListItem> yearList { get; set; }
        public List<System.Web.Mvc.SelectListItem> monthList { get; set; }
    }


    public class ShoppingCartRemoveModel
    {
        public string Message { get; set; }
        public decimal CartTotal { get; set; }
        public int CartCount { get; set; }
        public int ItemCount { get; set; }
        public int DeleteId { get; set; }

    }

    //public int RemoveFromCart(int id)
    //{
    //	// Get the cart
    //	var cartItem = storeDB.Carts.Single(
    //   cart => cart.CartId == ShoppingCartId && cart.RecordId == id);
    //int itemCount = 0;
    //	if (cartItem != null)
    //	{
    //		if (cartItem.Count > 1)
    //		{
    //			cartItem.Count--;
    //			itemCount = cartItem.Count;
    //		}
    //		else
    //		{
    //			storeDB.Carts.Remove(cartItem);
    //		}
    //		// Save changes
    //		storeDB.SaveChanges();
    //	}
    //	return itemCount;
}

