using MGA.Base.AccountBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGA.DataLayer.Account
{
	public class AccountDL
	{
		#region Declaration
		DataSet dsContainer;
		DataTable dtContainer;

		#endregion
		#region Method Login_Load
		public DataSet Login_Load(AccountBaseclass admin)
		{
			//dtContainer = new DataTable();
			dsContainer = new DataSet();
			try
			{
				MyParameter[] myParams ={
										   new MyParameter("@Email", admin.username),
										   new MyParameter("@Password", admin.password)

										};
				Common.Set_Procedures("Login_Load");
				Common.Set_ParameterLength(myParams.Length);
				Common.Set_Parameters(myParams);
				dsContainer = Common.Execute_Procedures_Select();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return dsContainer;
		}
		#endregion

		#region Method AddGuestUserCart
		public DataSet AddGuestUserCart(string xmltext, int userid)
		{
			//dtContainer = new DataTable();
			dsContainer = new DataSet();
			try
			{
				MyParameter[] myParams ={
										   new MyParameter("@XMLText", xmltext),
										   new MyParameter("@UserId", userid)


										};
				Common.Set_Procedures("AddGuestUserCart");
				Common.Set_ParameterLength(myParams.Length);
				Common.Set_Parameters(myParams);
				dsContainer = Common.Execute_Procedures_Select();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return dsContainer;
		}
		#endregion
		#region method UserRegistration
		//public DataTable UserRegistration(AccountBase accountBase)
		//{
		//	dtContainer = new DataTable();
		//	dsContainer = new DataSet();
		//	try
		//	{

		//		MyParameter[] myParams ={
		//		new MyParameter("@RoleId",accountBase.UserType),
		//		new MyParameter("@Email",accountBase.UserName),
		//		new MyParameter("@Password",accountBase.Password),
		//		new MyParameter("@FirstName",accountBase.FirstName),
		//		new MyParameter("@LastName",accountBase.LastName),
		//		new MyParameter("@MobileNo",accountBase.MobileNo)
		//		};
		//		Common.Set_Procedures("sp_CreateUser");
		//		Common.Set_ParameterLength(myParams.Length);
		//		Common.Set_Parameters(myParams);
		//		dtContainer = Common.Execute_Procedures_LoadData();
		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;
		//	}
		//	return dtContainer;
		//}

		public DataSet UserRegistration(AccountBase accountBase)
		{
			dsContainer = new DataSet();
			try
			{
				MyParameter[] myParams ={
										  new MyParameter("@RoleId",accountBase.UserType),
											new MyParameter("@Email",accountBase.UserName),
											new MyParameter("@Password",accountBase.Password),
											new MyParameter("@FirstName",accountBase.FirstName),
											new MyParameter("@LastName",accountBase.LastName),
											new MyParameter("@MobileNo",accountBase.MobileNo)

										};
				Common.Set_Procedures("sp_CreateUser");
				Common.Set_ParameterLength(myParams.Length);
				Common.Set_Parameters(myParams);
				dsContainer = Common.Execute_Procedures_Select();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return dsContainer;
		}

		#endregion

		#region method UserRegistration
		public DataTable CreatePlaceOrderGuestUser(AccountBase accountBase)
		{
			dtContainer = new DataTable();
			dsContainer = new DataSet();
			try
			{

				MyParameter[] myParams ={

									  new MyParameter("@UserName",accountBase.UserName),
											new MyParameter("@FirstName",accountBase.FirstName)
											 //new MyParameter("@Address",accountBase.Address)

							   };
				Common.Set_Procedures("CreatePlaceOrderGuestUser");
				Common.Set_ParameterLength(myParams.Length);
				Common.Set_Parameters(myParams);
				dtContainer = Common.Execute_Procedures_LoadData();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return dtContainer;
		}
		#endregion


		#region method GuestUserRegistration
		public DataTable GuestUserRegistration(AccountBase accountBase)
		{
			dtContainer = new DataTable();
			dsContainer = new DataSet();
			try
			{

				MyParameter[] myParams ={

									  new MyParameter("@UserName",accountBase.UserName),
											new MyParameter("@FirstName",accountBase.FirstName),
												new MyParameter("@LastName",accountBase.LastName),

														new MyParameter("@Gender",accountBase.Gender),
															new MyParameter("@Usertype",accountBase.UserType),
																new MyParameter("@Password",accountBase.Password),

																 new MyParameter("@MobileNo",accountBase.MobileNo),
																  new MyParameter("@userguid",accountBase.UserGuid),
																  new MyParameter("@XMLText",accountBase.RefCode)




							   };
				Common.Set_Procedures("CreateguestUser");
				Common.Set_ParameterLength(myParams.Length);
				Common.Set_Parameters(myParams);
				dtContainer = Common.Execute_Procedures_LoadData();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return dtContainer;
		}
		#endregion

		#region method Profile_LoadById
		public DataTable Profile_LoadById(AccountBase accountBase)
		{
			dtContainer = new DataTable();
			dsContainer = new DataSet();
			try
			{

				MyParameter[] myParams ={
									  new MyParameter("@UserId",accountBase.UserId),
							   };
				Common.Set_Procedures("Profile_LoadById");
				Common.Set_ParameterLength(myParams.Length);
				Common.Set_Parameters(myParams);
				dtContainer = Common.Execute_Procedures_LoadData();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return dtContainer;
		}
		#endregion

		#region method Profile_Update
		public DataTable Profile_Update(AccountBase accountBase)
		{
			dtContainer = new DataTable();
			dsContainer = new DataSet();
			try
			{

				MyParameter[] myParams ={
									  new MyParameter("@UserId",accountBase.UserId),
										new MyParameter("@FirstName",accountBase.FirstName),
										  new MyParameter("@LastName",accountBase.LastName),
											new MyParameter("@MobileNo",accountBase.MobileNo),
											  new MyParameter("@UserName",accountBase.UserName),
											   new MyParameter("@Email",accountBase.Email),
												new MyParameter("@Gender",accountBase.Gender),
												new MyParameter("@IsActive",accountBase.IsActive),
												 new MyParameter("@UserGuid",accountBase.UserGuid),
													new MyParameter("@IsEmailVerify",accountBase.IsEmailVerify)
							   };
				Common.Set_Procedures("Profile_Update");
				Common.Set_ParameterLength(myParams.Length);
				Common.Set_Parameters(myParams);
				dtContainer = Common.Execute_Procedures_LoadData();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return dtContainer;
		}
		#endregion
		#region method ChangePassword
		public DataTable ChangePassword(AccountBase accountBase)
		{
			dtContainer = new DataTable();
			dsContainer = new DataSet();
			try
			{

				MyParameter[] myParams ={
									  new MyParameter("@UserId",accountBase.UserId),
										new MyParameter("@Password",accountBase.Password)

							   };
				Common.Set_Procedures("ChangePassword");
				Common.Set_ParameterLength(myParams.Length);
				Common.Set_Parameters(myParams);
				dtContainer = Common.Execute_Procedures_LoadData();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return dtContainer;
		}
		#endregion
		#region method UpdatePassword
		public DataTable UpdatePassword(AccountBase accountBase)
		{
			dtContainer = new DataTable();
			dsContainer = new DataSet();
			try
			{

				MyParameter[] myParams ={
									  new MyParameter("@Email",accountBase.Email),
										new MyParameter("@Password",accountBase.Password)

							   };
				Common.Set_Procedures("UpdatePassword");
				Common.Set_ParameterLength(myParams.Length);
				Common.Set_Parameters(myParams);
				dtContainer = Common.Execute_Procedures_LoadData();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return dtContainer;
		}
		#endregion
		#region method GetPassword
		public DataTable GetPassword(AccountBase accountBase)
		{
			dtContainer = new DataTable();
			dsContainer = new DataSet();
			try
			{

				MyParameter[] myParams ={
									  new MyParameter("@UserId",accountBase.UserId)


							   };
				Common.Set_Procedures("GetPassword");
				Common.Set_ParameterLength(myParams.Length);
				Common.Set_Parameters(myParams);
				dtContainer = Common.Execute_Procedures_LoadData();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return dtContainer;
		}
		#endregion
		#region method IsActive_Update
		public DataTable IsActive_Update(AccountBase accountBase)
		{
			dtContainer = new DataTable();
			dsContainer = new DataSet();
			try
			{

				MyParameter[] myParams ={

												new MyParameter("@IsActive",accountBase.IsActive),
												 new MyParameter("@IsEmailVerify",accountBase.IsEmailVerify),
												 new MyParameter("@UserGuid",accountBase.UserGuid)
							   };
				Common.Set_Procedures("IsActive_Update");
				Common.Set_ParameterLength(myParams.Length);
				Common.Set_Parameters(myParams);
				dtContainer = Common.Execute_Procedures_LoadData();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return dtContainer;
		}
		#endregion
		#region method Check_Email
		public DataTable Check_Email(AccountBase accountBase)
		{
			dtContainer = new DataTable();
			dsContainer = new DataSet();
			try
			{

				MyParameter[] myParams ={

									  new MyParameter("@Email",accountBase.UserName),
											new MyParameter("@MobNo",accountBase.MobileNo)
							   };
				Common.Set_Procedures("Check_Email");
				Common.Set_ParameterLength(myParams.Length);
				Common.Set_Parameters(myParams);
				dtContainer = Common.Execute_Procedures_LoadData();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return dtContainer;
		}
		#endregion
		#region method VerifyEmailAccount
		public DataTable VerifyEmailAccount(AccountBase accountBase)
		{
			dtContainer = new DataTable();
			dsContainer = new DataSet();
			try
			{

				MyParameter[] myParams ={

									  new MyParameter("@UserGuid",accountBase.UserGuid)
							   };
				Common.Set_Procedures("VerifyAccount");
				Common.Set_ParameterLength(myParams.Length);
				Common.Set_Parameters(myParams);
				dtContainer = Common.Execute_Procedures_LoadData();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return dtContainer;
		}
		#endregion

		#region method GetExistEmail
		public DataTable GetExistEmail(AccountBase accountBase)
		{
			dtContainer = new DataTable();
			dsContainer = new DataSet();
			try
			{

				MyParameter[] myParams ={
										  new MyParameter("@UserId",accountBase.UserId),
									  new MyParameter("@Email",accountBase.Email)

							   };
				Common.Set_Procedures("GetExistEmail");
				Common.Set_ParameterLength(myParams.Length);
				Common.Set_Parameters(myParams);
				dtContainer = Common.Execute_Procedures_LoadData();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return dtContainer;
		}
		#endregion
		#region method ForgetPasswordEmail
		public DataTable ForgetPasswordEmail(AccountBase accountBase)
		{
			dtContainer = new DataTable();
			dsContainer = new DataSet();
			try
			{

				MyParameter[] myParams ={

									  new MyParameter("@Email",accountBase.Email)

							   };
				Common.Set_Procedures("ForgetPasswordEmail");
				Common.Set_ParameterLength(myParams.Length);
				Common.Set_Parameters(myParams);
				dtContainer = Common.Execute_Procedures_LoadData();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return dtContainer;
		}
		#endregion

		#region method GetExistMobileNo
		public DataTable GetExistMobileNo(AccountBase accountBase)
		{
			dtContainer = new DataTable();
			dsContainer = new DataSet();
			try
			{

				MyParameter[] myParams ={
										   new MyParameter("@MobileNo",accountBase.MobileNo),
									new MyParameter("@UserId",accountBase.UserId)

							   };
				Common.Set_Procedures("GetExistMobileNo");
				Common.Set_ParameterLength(myParams.Length);
				Common.Set_Parameters(myParams);
				dtContainer = Common.Execute_Procedures_LoadData();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return dtContainer;
		}
		#endregion


		#region Reset Password
		public DataTable AllUserDetail(string email, int Sno, int Action)
		{
			dtContainer = new DataTable();
			try
			{

				MyParameter[] myParams ={
										   new MyParameter("@Email",email),
											new MyParameter("@UserId",Sno),
											new MyParameter("@Action",Action)
							   };
				Common.Set_Procedures("sp_UserDetail");
				Common.Set_ParameterLength(myParams.Length);
				Common.Set_Parameters(myParams);
				dtContainer = Common.Execute_Procedures_LoadData();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return dtContainer;
		}
		#endregion

		#region method CheckEmailExists
		public DataTable CheckEmailExists(AccountBase accountBase)
		{
			dtContainer = new DataTable();
			dsContainer = new DataSet();
			try
			{

				MyParameter[] myParams ={
										 new MyParameter("@Email",accountBase.Email),
											new MyParameter("@UserId",0),
											new MyParameter("@Action",2)
							   };
				Common.Set_Procedures("sp_UserDetail");
				Common.Set_ParameterLength(myParams.Length);
				Common.Set_Parameters(myParams);
				dtContainer = Common.Execute_Procedures_LoadData();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return dtContainer;
		}
		#endregion

		#region Update Password
		public DataTable UpdatePassword(string password, string token)
		{
			dtContainer = new DataTable();
			try
			{

				MyParameter[] myParams ={
										   new MyParameter("@Password",password),
											new MyParameter("@PasswordResetToken",token)
							   };
				Common.Set_Procedures("UserInfoResetPassword");
				Common.Set_ParameterLength(myParams.Length);
				Common.Set_Parameters(myParams);
				dtContainer = Common.Execute_Procedures_LoadData();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return dtContainer;
		}
		#endregion

		
	}
}
