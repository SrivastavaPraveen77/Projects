using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MGA.BASE.Home;
using MGAChargerEcommerce.Models;
using MGAChargerEcommerece.Helper;
using System.Configuration;
using MGA.Utility;
using System.Net.Mail;
using System.Net;
using MGA.Base.Admin;

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MGAChargerEcommerce.Controllers
{
	public class HomeController : Controller
	{
		MGA.Base.ActionResult actionResult = new MGA.Base.ActionResult();
		MGA.ActionLayer.Home.HomeAL homeAction = new MGA.ActionLayer.Home.HomeAL();

		#region Declaration

		MGA.ActionLayer.Account.AccountAction accountAction = new MGA.ActionLayer.Account.AccountAction();
		MGA.ActionLayer.Admin.AdminAL adminAction = new MGA.ActionLayer.Admin.AdminAL();

		#endregion

		public ActionResult Index()
		{
			ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your app description page.";
            /*Praveen Changes On 21 September 2019*/

            ManagePages model = new ManagePages();
            model.PageId = 5;//means About us page
            actionResult = adminAction.GetPage(model);
            if (actionResult.IsSuccess)
            {
                HomeAboutusModel page = new HomeAboutusModel();
                page = Helper.ConvertTo<HomeAboutusModel>(actionResult.dtResult).ElementAtOrDefault(0);
                return View(page);
            }
            else
                return View();


            /*End*/

			//return View();
		}


		public ActionResult MediaRoom()
		{
			ViewBag.Message = "Your media page.";

			return View();
		}


		public ActionResult Contact()
		{
            ContactUsBase model = new ContactUsBase();
            model.ID = 1;//means contact us page
            actionResult = adminAction.getContactUs(model);
            if (actionResult.IsSuccess)
            {
                MailModel page = new MailModel();
                page = Helper.ConvertTo<MailModel>(actionResult.dtResult).ElementAtOrDefault(0);
                return View(page);
            }
            else
                return View();
			
		}


		[HttpPost]
		public ViewResult Contact(MailModel _objModelMail)
		{
			try
			{
				if (ModelState.IsValid)
				{
                    

                    const string toEmail = "helpdesk@mgacharger.com";
                    const string fromEmail = "support@mgacharger.com";

					string BodyText = "";
					BodyText = "<b>Dear Sir,</b><br/><br/>";
					BodyText = BodyText + "Following are the details of the visitor who contacted you through your website 'mgacharger.com'<br /><br />";

					BodyText = BodyText + "<b>Email:  </b>" + _objModelMail.From + "<br/><br/>";
					BodyText = BodyText + "<b>Phone No:  </b>" + _objModelMail.Mobile + "<br/><br/>";
					BodyText = BodyText + "<b>Message:  </b>" + _objModelMail.Body + "<br/><br/>";
					BodyText = BodyText + "Thanks,<br /><br/>Web Admin";

                    //var message = new MailMessage
                    //{
                    //    From = new MailAddress(fromEmail),
                    //    To = { toEmail },
                    //    Subject = _objModelMail.Subject,
                    //    Body = BodyText,
                    //    IsBodyHtml = true,
                    //    DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                    //};


                    MailMessage mail = new MailMessage("support@mgacharger.com", "priyanshu103@gmail.com");
                    mail.Subject = "Subject";
                    mail.IsBodyHtml = true;
                    mail.Body = "this is email body";

                    SmtpClient client = new SmtpClient("priyanshu103@gmail.com");
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential("priyanshu103@gmail.com", "9648575749");
                    client.Port = 25;

                    client.Send(mail);




                    //using (SmtpClient smtpClient = new SmtpClient("priyanshu103@gmail.com"))
                    //{
                    //    smtpClient.Credentials = new NetworkCredential("priyanshu103@gmail.com", "9648575749");
                    //    smtpClient.Port = 25;
                    //    smtpClient.EnableSsl = false;
                    //    smtpClient.Send(message);
                    //}


					ModelState.Clear();
					TempData["SuccessMessage"] = "Mail send successfully.";
					return View("Contact", _objModelMail);

					
				}
				else
				{
					TempData["ErrorMessage"] = "Some error occurred. Please try again later.";
				}
			}
			catch (Exception excep)
			{

                //TempData["ErrorMessage"] = "Some error occurred. Please try again later.";
               
				//ignore it or you can retry .
                TempData["ErrorMessage"] = "Mail Sent Successfully.";
			}
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public ActionResult FMailFormSubmit(MailModel _objModelMail)
		{
			try
			{
				if (ModelState.IsValid)
				{
					const string toEmail = "priyanshu103@gmail.com";
                    const string fromEmail = "support@mgacharger.com";

					string BodyText = "";
					BodyText = "<b>Dear Sir,</b><br/><br/>";
					BodyText = BodyText + "Following are the details of the visitor who contacted you through your website 'mgacharger.com'<br /><br />";

					BodyText = BodyText + "<b>Message:  </b>" + _objModelMail.Body + "<br/><br/>";
					BodyText = BodyText + "Thanks,<br /><br/>Web Admin";

					var message = new MailMessage
					{
						From = new MailAddress(fromEmail),
						To = { toEmail },
						Subject = _objModelMail.Subject,
						Body = BodyText,
						IsBodyHtml = true,
						DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
					};
                    using (SmtpClient smtpClient = new SmtpClient("support@mgacharger.com"))
					{
                        smtpClient.Credentials = new NetworkCredential("support@mgacharger.com", "Mgacharger@123");
						smtpClient.Port = 25;
						smtpClient.EnableSsl = false;
						smtpClient.Send(message);
					}

					ModelState.Clear();
					TempData["SuccessMessage"] = "Mail send successfully.";
					return View("Contact", _objModelMail);

					//const string fromEmail = "yourEmail@YourDomain.com";
					//var message = new MailMessage
					//{
					//	From = new MailAddress(fromEmail),
					//	To = { toEmail },
					//	Subject = subject,
					//	Body = body,
					//	DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
					//};
				}
				else
				{
					TempData["ErrorMessage"] = "Some error occurred. Please try again later.";
				}
			}
			catch (Exception excep)
			{
				TempData["ErrorMessage"] = "Some error occurred. Please try again later.";
				//ignore it or you can retry .
			}
			return View();
		}


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
				MGA.Base.AccountBase.AccountBaseclass accountbase = new MGA.Base.AccountBase.AccountBaseclass();

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
					//Sendmail();
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
							Session["Email"] = actionResult.dsResult.Tables[0].Rows[0]["Email"].ToString();
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
								TempData["LoginErrorMessage"] = "Invalid Username or Password.";
							}
							if (Convert.ToInt32(actionResult.dsResult.Tables[0].Rows[0][0]) == -1)
							{
								TempData["LoginErrorMessage"] = "Your Account is Inactive or Deleted.";
							}
							//if (Convert.ToInt32(actionResult.dsResult.Tables[0].Rows[0][0]) == -2)
							//{
							//	TempData["LoginErrorMessage"] = "Please Verify your mail.";
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

		#region checkValidation
		public JsonResult checkValidation(string email)
		{
			MGA.Base.AccountBase.AccountBase accountbase1 = new MGA.Base.AccountBase.AccountBase();
			RegisterModel Model = new RegisterModel();
			string msg = null;
			string json = string.Empty;
			if (email != "")
			{
				accountbase1.UserName = email;
				TempData["Email"] = email;
				accountbase1.UserId = 1;
				actionResult = accountAction.Check_Email(accountbase1);
				if (actionResult.dtResult.Rows.Count > 0)
				{
					if (actionResult.dtResult.Rows[0][0].ToString() == "1")
					{
						json = "{\"Status\":\"1\"}";
					}
					else if (actionResult.dtResult.Rows[0][0].ToString() == "0")
					{
						json = "{\"Status\":\"0\"}";
					}
				}
				else
				{
					json = "{\"Status\":\"-1\"}";
				}


			}
			return Json(json, JsonRequestBehavior.AllowGet);
		}
		#endregion

		[System.Web.Mvc.HttpPost]
		public ActionResult RegisterFormSubmit(RegisterModel Model)
		{
			MGA.Base.AccountBase.AccountBase accountbase1 = new MGA.Base.AccountBase.AccountBase();
			try
			{
				//int id = 0;
				//string otpResponse = string.Empty;
				//string requestId = string.Empty;
				//accountbase1.CustomerTypeid = Model.CustomerTypeid;
				//acountbase.Gender = Model.Gender;               

				accountbase1.Password = Model.Password;
				accountbase1.FirstName = Model.FirstName;
				accountbase1.LastName = Model.LastName;
				accountbase1.MobileNo = Model.MobileNo;
				accountbase1.UserName = Model.Email;
				accountbase1.UserType = 2; //RoleId

				actionResult = accountAction.UserRegistration(accountbase1);
				if (actionResult.IsSuccess)
				{
					if (Convert.ToInt32(actionResult.dsResult.Tables[0].Rows[0][0].ToString()) > 0)
					{
						Session["userId"] = actionResult.dsResult.Tables[0].Rows[0]["UserId"].ToString();
						Session["userTel"] = Model.MobileNo;
						Session["userName"] = Model.FirstName;
						Session["Email"] = Model.Email;
						Session["RoleId"] = 2;
						TempData["RegSuccessMessage"] = "You have Registered Successfully.";
						return RedirectToAction("Index", "Home");
					}
					else
					{
						if (Convert.ToInt32(actionResult.dsResult.Tables[0].Rows[0][0]) == -10)
						{
							TempData["RegErrorMessage"] = "Email already exists. Choose another.";
							return RedirectToAction("LoginRegister", "Home");
						}
						else
						{
							TempData["RegErrorMessage"] = "Data not saved Might be email already exist.";
							return RedirectToAction("LoginRegister", "Home");

						}
					}
				}
			}
			catch (Exception ex)
			{
				TempData["RegErrorMessage"] = "Error occured please try again later. ";
				return RedirectToAction("LoginRegister", "Home");
			}

			return View(Model);
		}


		[HttpGet]
		public ActionResult RegisterView()
		{
			return View();
		}

		[HttpPost]
		public ActionResult RegisterView(RegisterModel Model)
		{
			MGA.Base.AccountBase.AccountBase accountbase1 = new MGA.Base.AccountBase.AccountBase();
			try
			{
				//int id = 0;
				//string otpResponse = string.Empty;
				//string requestId = string.Empty;
				//accountbase1.CustomerTypeid = Model.CustomerTypeid;
				//acountbase.Gender = Model.Gender;               

				accountbase1.Password = Model.Password;
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

					TempData["RegSuccessMessage"] = "You have Registered Successfully Please Verify your email to login.";
					return RedirectToAction("RegisterView", "Home");
				}

			}
			catch (Exception)
			{
				TempData["RegErrorMessage"] = "Error occured please try again later. ";
				return RedirectToAction("RegisterView", "Home");

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


		[HttpGet]
		public ActionResult ForgetPassword()
		{
			return View();
		}

		[HttpPost]
		public ActionResult ForgetPassword(FormCollection fc)
		{
			string passwordResetToken = Guid.NewGuid().ToString();
			string EmailId = fc["Email"].ToString();
            string Password = fc["Password"].ToString();
            bool isChanged = adminAction.UpdateuserPassword(EmailId, Password);
            if (isChanged)
			{
				
				TempData["SuccessMessage"] = "Password has changed successfully.";
                //return RedirectToAction("Index", "Home");
			}
			else
			{
				TempData["ErrorMessage"] = "Please check your emailId seems its Incorrect.";
			}
			return View();
		}

        //public JsonResult SendOTP(string mobileNumber)
        //{
        //    int otpValue = new Random().Next(100000, 999999);
        //    var status = "";
        //    try
        //    {
        //        //string recipient = ConfigurationManager.AppSettings["RecipientNumber"].ToString();
        //        string APIKey = ConfigurationManager.AppSettings["APIKey"].ToString();

        //        string message = "Your OTP Number is " + otpValue + " ( Sent By : MGACharger-N.K Gupta)";
        //        String encodedMessage = HttpUtility.UrlEncode(message);

        //        using (var webClient = new WebClient())
        //        {
        //            byte[] response = webClient.UploadValues("https://api.textlocal.in/send/", new NameValueCollection(){
                                        
        //                                 {"apikey" , APIKey},
        //                                 {"numbers" , mobileNumber},
        //                                 {"message" , encodedMessage},
        //                                 {"sender" , "TXTLCL"}});

        //            string result = System.Text.Encoding.UTF8.GetString(response);

        //            var jsonObject = JObject.Parse(result);

        //            status = jsonObject["status"].ToString();

        //            Session["CurrentOTP"] = otpValue;
        //        }


        //        return Json(status, JsonRequestBehavior.AllowGet);


        //    }
        //    catch (Exception e)
        //    {

        //        throw (e);

        //    }

        //}


        public JsonResult SendOTP(String Recipient)
        {
            //string ipAddres = Common.getIPAddress();
            bool result = false;
            try
            {
                
                int otpValue = new Random().Next(100000, 999999);
                string message = "Your OTP Number is " + otpValue + " ( Sent By : MGA Electronics)";
                WebClient Client = new WebClient();
                Recipient = Recipient.Trim();
                if (Recipient.Substring(Recipient.Length - 1, 1) == ",")
                    Recipient = Recipient.Substring(0, Recipient.Length - 1);

                //string baseurl = "http://india.timessms.com/http-api/receiverall.aspx?username=titus_otpl&password=71919800&sender=OMNINET&cdmasender=9935536635&to=" + Recipient + "&message=" +"Hi";

                string baseurl = "http://smsfortius.com/api/mt/SendSMS?user=mgaelectronics&password=123123&senderid=MGAELE&channel=Trans&DCS=0&flashsms=0&number=" + Recipient + "&text=" + message + "&route=2";


                Stream data = Client.OpenRead(baseurl);
                StreamReader reader = new StreamReader(data);
                string s = reader.ReadToEnd();
                data.Close();
                reader.Close();
                result = true;
                Session["CurrentOTP"] = otpValue;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }



        [HttpPost]
        public JsonResult VerifyOTP(string otp)
        {
            bool result = false;

            string sessionOTP = Session["CurrentOTP"].ToString();

            if (otp == sessionOTP)
            {
                result = true;

            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }


		public ActionResult CheckEmailExists(String Email)
		{
			MGA.Base.AccountBase.AccountBase accountbase = new MGA.Base.AccountBase.AccountBase();
			accountbase.Email = Email;
			MGA.Base.ActionResult actionResult = new MGA.Base.ActionResult();
			MGA.ActionLayer.Account.AccountAction accountAction = new MGA.ActionLayer.Account.AccountAction();
			actionResult = accountAction.CheckEmailExists(accountbase);

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




	}

}
