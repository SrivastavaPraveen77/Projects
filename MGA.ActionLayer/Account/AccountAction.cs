using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MGA.Base;
using MGA.Base.AccountBase;
using MGA.ActionLayer.Account;
using MGA.DataLayer.Account;

namespace MGA.ActionLayer.Account
{
	public class AccountAction
	{
		#region Declaration
		MGA.DataLayer.Account.AccountDL accountdl = new MGA.DataLayer.Account.AccountDL();

		MGA.Base.ActionResult actionResult = new MGA.Base.ActionResult();
		#endregion

		#region Method Login_Load
		public ActionResult Login_Load(AccountBaseclass admin)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dsResult = accountdl.Login_Load(admin);
				if (actionResult.dsResult != null && actionResult.dsResult.Tables.Count > 0)
				{
					actionResult.IsSuccess = true;
				}
			}
			catch (Exception ex)
			{

			}
			return actionResult;
		}
		#endregion

		#region Method AddGuestUserCart
		public ActionResult AddGuestUserCart(string xmltext, int userid)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dsResult = accountdl.AddGuestUserCart(xmltext, userid);
				if (actionResult.dsResult != null && actionResult.dsResult.Tables.Count > 0)
				{
					actionResult.IsSuccess = true;
				}
			}
			catch (Exception ex)
			{

			}
			return actionResult;
		}
		#endregion




		#region UserRegistration
		public ActionResult UserRegistration(AccountBase accountBase)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dsResult = accountdl.UserRegistration(accountBase);
				if (actionResult.dsResult != null && actionResult.dsResult.Tables.Count > 0)
				{
					actionResult.IsSuccess = true;
				}
			}
			catch (Exception)
			{


			}
			return actionResult;
		}
		#endregion





		//#region Method Login_Load
		//public ActionResult UserRegistration(AccountBase accountBase)
		//{
		//	actionResult = new ActionResult();
		//	try
		//	{
		//		actionResult.dsResult = accountdl.UserRegistration(accountBase);
		//		if (actionResult.dsResult != null && actionResult.dsResult.Tables.Count > 0)
		//		{
		//			actionResult.IsSuccess = true;
		//		}
		//	}
		//	catch (Exception ex)
		//	{

		//	}
		//	return actionResult;
		//}
		//#endregion


		#region UserRegistration
		public ActionResult CreatePlaceOrderGuestUser(AccountBase accountBase)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dtResult = accountdl.CreatePlaceOrderGuestUser(accountBase);
				if (actionResult.dtResult.Rows.Count > 0)
				{
					actionResult.IsSuccess = true;
				}
			}
			catch (Exception)
			{


			}
			return actionResult;
		}
		#endregion


		#region GuestUserRegistration
		public ActionResult GuestUserRegistration(AccountBase accountBase)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dtResult = accountdl.GuestUserRegistration(accountBase);
				if (actionResult.dtResult.Rows.Count > 0)
				{
					if (Convert.ToString(actionResult.dtResult.Rows[0][0]) == "-10")
						actionResult.IsSuccess = false;
					else
						actionResult.IsSuccess = true;
				}
			}
			catch (Exception)
			{


			}
			return actionResult;
		}
		#endregion

		#region
		public ActionResult Profile_LoadById(AccountBase accountBase)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dtResult = accountdl.Profile_LoadById(accountBase);
				if (actionResult.dtResult.Rows.Count > 0)
				{
					actionResult.IsSuccess = true;
				}
			}
			catch (Exception)
			{


			}
			return actionResult;
		}
		#endregion

		#region
		public ActionResult Profile_Update(AccountBase accountBase)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dtResult = accountdl.Profile_Update(accountBase);
				if (actionResult.dtResult.Rows.Count > 0)
				{
					actionResult.IsSuccess = true;
				}
			}
			catch (Exception)
			{


			}
			return actionResult;
		}
		#endregion
		#region
		public ActionResult ChangePassword(AccountBase accountBase)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dtResult = accountdl.ChangePassword(accountBase);
				if (actionResult.dtResult.Rows.Count > 0)
				{
					actionResult.IsSuccess = true;
				}
			}
			catch (Exception)
			{


			}
			return actionResult;
		}
		#endregion


		#region
		public ActionResult CheckEmailExists(AccountBase accountBase)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dtResult = accountdl.CheckEmailExists(accountBase);
				if (actionResult.dtResult.Rows.Count > 0)
				{
					actionResult.IsSuccess = true;
				}
			}
			catch (Exception)
			{


			}
			return actionResult;
		}
		#endregion

		#region
		public ActionResult UpdatePassword(AccountBase accountBase)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dtResult = accountdl.UpdatePassword(accountBase);
				if (actionResult.dtResult.Rows.Count > 0)
				{
					actionResult.IsSuccess = true;
				}
			}
			catch (Exception)
			{


			}
			return actionResult;
		}
		#endregion
		#region
		public ActionResult GetPassword(AccountBase accountBase)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dtResult = accountdl.GetPassword(accountBase);
				if (actionResult.dtResult.Rows.Count > 0)
				{
					actionResult.IsSuccess = true;
				}
			}
			catch (Exception)
			{


			}
			return actionResult;
		}
		#endregion

		#region
		public ActionResult IsActive_Update(AccountBase accountBase)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dtResult = accountdl.IsActive_Update(accountBase);
				if (actionResult.dtResult.Rows.Count > 0)
				{
					actionResult.IsSuccess = true;
				}
			}
			catch (Exception)
			{


			}
			return actionResult;
		}
		#endregion
		#region
		public ActionResult GetExistEmail(AccountBase accountBase)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dtResult = accountdl.GetExistEmail(accountBase);
				if (actionResult.dtResult.Rows.Count > 0)
				{
					actionResult.IsSuccess = true;
				}
			}
			catch (Exception)
			{


			}
			return actionResult;
		}
		#endregion
		#region
		public ActionResult ForgetPasswordEmail(AccountBase accountBase)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dtResult = accountdl.ForgetPasswordEmail(accountBase);
				if (actionResult.dtResult.Rows.Count > 0)
				{
					actionResult.IsSuccess = true;
				}
			}
			catch (Exception)
			{


			}
			return actionResult;
		}
		#endregion
		#region
		public ActionResult GetExistMobileNo(AccountBase accountBase)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dtResult = accountdl.GetExistMobileNo(accountBase);
				if (actionResult.dtResult.Rows.Count > 0)
				{
					actionResult.IsSuccess = true;
				}
			}
			catch (Exception)
			{


			}
			return actionResult;
		}
		#endregion
		#region Check_Email
		public ActionResult Check_Email(AccountBase accountBase)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dtResult = accountdl.Check_Email(accountBase);
				if (actionResult.dtResult.Rows.Count > 0)
				{
					actionResult.IsSuccess = true;
				}
			}
			catch (Exception)
			{


			}
			return actionResult;
		}
		#endregion


		#region VerifyEmailAccount
		public ActionResult VerifyEmailAccount(AccountBase accountBase)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dtResult = accountdl.VerifyEmailAccount(accountBase);
				if (actionResult.dtResult.Rows.Count > 0)
				{
					if (actionResult.dtResult.Rows[0][0].ToString() != "-10")
					{
						actionResult.IsSuccess = true;
					}
					else
					{
						actionResult.IsSuccess = false;
					}
				}
			}
			catch (Exception)
			{


			}
			return actionResult;
		}
		#endregion


		#region Reset Password
		public ActionResult ResetPassword(string email)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dtResult = accountdl.AllUserDetail(email,0,1);
				if (actionResult.dtResult.Rows.Count > 0)
				{
					if (Convert.ToInt32(actionResult.dtResult.Rows[0][0]) > 0)
					{
						actionResult.IsSuccess = true;
					}
					else
					{
						actionResult.IsSuccess = false;
					}
				}
			}
			catch (Exception)
			{


			}
			return actionResult;
		}
		#endregion

		#region update Password
		public ActionResult UpdatePassword(string password, string token)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dtResult = accountdl.UpdatePassword(password, token);
				if (actionResult.dtResult.Rows.Count > 0)
				{
					if (Convert.ToInt32(actionResult.dtResult.Rows[0][0]) > 0)
					{
						actionResult.IsSuccess = true;
					}
					else
					{
						actionResult.IsSuccess = false;
					}
				}
			}
			catch (Exception)
			{


			}
			return actionResult;
		}
		#endregion
	}
}
