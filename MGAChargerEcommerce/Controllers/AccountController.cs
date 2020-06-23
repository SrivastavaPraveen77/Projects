using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using MGAChargerEcommerce.Filters;
using MGAChargerEcommerce.Models;
using System.Configuration;
using MGA.Utility;

namespace MGAChargerEcommerce.Controllers
{
	[Authorize]
	[InitializeSimpleMembership]
	public class AccountController : Controller
	{
		MGA.Base.AccountBase.AccountBaseclass accountbase = new MGA.Base.AccountBase.AccountBaseclass();

		#region Declaration

		MGA.Base.ActionResult actionResult = new MGA.Base.ActionResult();
		MGA.ActionLayer.Account.AccountAction accountAction = new MGA.ActionLayer.Account.AccountAction();
		MGA.ActionLayer.Admin.AdminAL adminAction = new MGA.ActionLayer.Admin.AdminAL();

		//string site = System.Configuration.ConfigurationManager.AppSettings["site"].ToString();
		#endregion

		[HttpGet]
		public ActionResult LoginRegister()
		{
			return View();
		}

		[HttpPost]
		public ActionResult LoginRegister(LoginModel model, FormCollection fc)
		{
			try
			{
				string url = Request.UrlReferrer.ToString();
				string returnUrl = string.Empty;
				try { returnUrl = url.IndexOf('?') != -1 ? url.Split('?')[0] != null ? url.Split('?')[1].Split('=')[1] : "" : ""; }
				catch { returnUrl = string.Empty; }

				string Newurl = url.ToString();
				var UserName = fc["UserName"];
				var Password = fc["Password"];
				accountbase.username = UserName;
				//string sKey = "" + ConfigurationManager.AppSettings["SKey"];
				//accountbase.password = CommonFunctions.EncryptTripleDES(Password, sKey);
				accountbase.password = Password;
				actionResult = accountAction.Login_Load(accountbase);
				if (actionResult.IsSuccess)
				{
					if (Convert.ToInt32(actionResult.dsResult.Tables[0].Rows.Count) > 0)
					{
						string userId = string.Empty;
						string userName = string.Empty;
						string userType = string.Empty;
						if (Convert.ToInt32(actionResult.dsResult.Tables[0].Rows[0][0]) > 0)
						{
							Session["userId"] = actionResult.dsResult.Tables[0].Rows[0]["UserId"].ToString();
							Session["userTel"] = actionResult.dsResult.Tables[0].Rows[0]["ContactNo"].ToString();
							Session["userName"] = actionResult.dsResult.Tables[0].Rows[0]["UserFirstName"].ToString();
							//Session["userType"] = actionResult.dsResult.Tables[0].Rows[0]["RoleId"].ToString();
							Session["Email"] = actionResult.dsResult.Tables[0].Rows[0]["Email"].ToString();
							//Session["shopping"] = actionResult.dsResult.Tables[1].Rows[0]["ItemCount"].ToString() + " " + actionResult.dsResult.Tables[1].Rows[0]["TotalAmount"].ToString();
							Session["RoleId"] = actionResult.dsResult.Tables[0].Rows[0]["RoleId"].ToString();

							if (Convert.ToInt32(actionResult.dsResult.Tables[0].Rows[0]["RoleId"]) == 1)
							{
								if (string.IsNullOrEmpty(returnUrl))
									return RedirectToAction("Dashboard", "Admin");
								else
									return Redirect(returnUrl);
							}
							else
							{
								List<cartmodel> guestcart = new List<cartmodel>();
								if (Session["guestcart"] != null)
								{
									guestcart = (List<cartmodel>)Session["guestcart"];
									if (guestcart.Count > 0)
									{

										string xmltext = string.Empty;
										xmltext += "<code>";
										for (int i = 0; i < guestcart.Count; i++)
										{

											xmltext += "<codes>";
											xmltext += "<UserId>" + actionResult.dsResult.Tables[0].Rows[0]["UserId"].ToString() + "</UserId>";
											xmltext += "<ProductId>" + guestcart[i].product + "</ProductId>";
											xmltext += "<TotalAmount>" + guestcart[i].amount + "</TotalAmount>";
											xmltext += "<Quantity>" + guestcart[i].quantity + "</Quantity>";

											xmltext += "<IsCheckout>0</IsCheckout>";

											xmltext += "<IsDelete>0</IsDelete>";
											xmltext += "</codes>";


										}
										xmltext += "</code>";
										int userid = Convert.ToInt32(actionResult.dsResult.Tables[0].Rows[0]["UserId"]);
										actionResult = accountAction.AddGuestUserCart(xmltext, userid);
										if (actionResult.IsSuccess)
										{
											Session["shopping"] = actionResult.dsResult.Tables[0].Rows[0]["ItemCount"].ToString() + " " + actionResult.dsResult.Tables[0].Rows[0]["TotalAmount"].ToString();

											Session["guestcart"] = null;
										}

									}

								}
								if (string.IsNullOrEmpty(returnUrl))
									return RedirectToAction("Index", "Home");
								else
									return Redirect(returnUrl);
							}

						}
						else
						{
							//check for Popup
							var check = 1;
							TempData["check"] = check;
							if (Convert.ToInt32(actionResult.dsResult.Tables[0].Rows[0][0]) == -10)
							{
								TempData["ErrorMessage"] = "Invalid Username or Password.";
							}
							if (Convert.ToInt32(actionResult.dsResult.Tables[0].Rows[0][0]) == -1)
							{
								TempData["ErrorMessage"] = "Your Account is Inactive or Deleted.";
							}
							//if (Convert.ToInt32(actionResult.dsResult.Tables[0].Rows[0][0]) == -2)
							//{
							//	TempData["ErrorMessage"] = "Please Verify your mail.";
							//}
							if (url != null)
							{
								return Redirect(Newurl);
							}
							return RedirectToAction("Login", "Account", new { check = check });
						}

					}
				}
			}
			catch (Exception ex)
			{

			}
			return View(model);

		}

		[HttpGet]
		public ActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Register(RegisterModel Model)
		{
			MGA.Base.AccountBase.AccountBase accountbase1 = new MGA.Base.AccountBase.AccountBase();
			try
			{
				//int id = 0;
				//string otpResponse = string.Empty;
				//string requestId = string.Empty;
				//accountbase1.CustomerTypeid = Model.CustomerTypeid;
				//acountbase.Gender = Model.Gender;               

				accountbase1.Password = "mypass123";
				accountbase1.FirstName = Model.FirstName;
				accountbase1.LastName = Model.LastName;
				accountbase1.MobileNo = Model.MobileNo;
				accountbase1.UserName = Model.Email;
				accountbase1.UserType = 2; //RoleId

				actionResult = accountAction.UserRegistration(accountbase1);
				if (actionResult.IsSuccess)
				{
					//string guid = accountbase1.UserGuid;
					//string token = accountbase1.UserName;
					//string FirstName = Model.FirstName + ' ' + Model.LastName;
					//string content = "Thank you for registering for Vidyarthi Kendra. To verify your account,<a href=" + site + "/Account/ConfirmRegistration?id=" + token + "> click here.</a> Please ignore this email if you did not register for Vidyarthi Kendra.";
					//bool res = SendMail.ConfirmationMail(accountbase1.UserName, FirstName, guid);

					TempData["SuccessMessage"] = "You have Registered Successfully Please Verify your email to login.";
					return RedirectToAction("Register", "Account");
				}

			}
			catch (Exception)
			{
				TempData["ErrorMessage"] = "Error occured please try again later. ";
				return RedirectToAction("Register", "Account");

			}
			return View();
		}


		public ActionResult Logout()
		{
			Session.Clear();
			Session.RemoveAll();
			Session.Abandon();
			return RedirectToAction("Index", "Home");
		}

	}
}
