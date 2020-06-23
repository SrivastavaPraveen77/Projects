using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGA.Base.AccountBase
{
	public class AccountBaseclass
	{
		#region Declarations

		private string _username = string.Empty;
		private string _password = string.Empty;
		private int _userId = 0;
		private int _state = 0;
		#endregion
		#region Properties

		public string username
		{
			get { return _username; }
			set { _username = value; }
		}
		public string password
		{
			get { return _password; }
			set { _password = value; }
		}
		public int State
		{
			get { return _state; }
			set { _state = value; }
		}

		#endregion
	}

	public class AccountBase
	{
		#region Declaration
		private string _RefCode = string.Empty;
		private int _Refid;

		public int Refid
		{
			get { return _Refid; }
			set { _Refid = value; }
		}

		public string RefCode
		{
			get { return _RefCode; }
			set { _RefCode = value; }
		}
		private string _UserName = string.Empty;
		private string _Password = string.Empty;
		private string _MobileNo = string.Empty;

		private int _UserType = 0;
		private string _FirstName = string.Empty;
		private string _LastName = string.Empty;
		private string _Gender = string.Empty;
		private bool _IsActive = false;
		private bool _IsEmailVerify = false;
		private bool _IsMobileVerify = false;
		private int _CustomerTypeid = 0;
		private bool _IsDelete = false;
		private bool _AccountUpdate = false;
		private bool _EmailUpdate = false;
		private Int64 _UserId = 0;
		private string _providerType = string.Empty;
		private string _providerId = string.Empty;
		private List<AccountBase> _Userlist = null;
		private bool _DeleteAccount = false;
		private bool _MobileUpdate = false;
		private string _OldPassword = string.Empty;
		private string _NewPassword = string.Empty;
		private string _Email = string.Empty;
		private string _userGuid = string.Empty;

		private string _facebookid;

		private string _provider;

		public string Provider
		{
			get { return _provider; }
			set { _provider = value; }
		}

		public string Facebookid
		{
			get { return _facebookid; }
			set { _facebookid = value; }
		}
		#endregion

		#region Property


		public string UserName
		{
			get { return _UserName; }
			set { _UserName = value; }
		}

		public string Password
		{
			get { return _Password; }
			set { _Password = value; }
		}

		public string MobileNo
		{
			get { return _MobileNo; }
			set { _MobileNo = value; }
		}




		public int UserType
		{
			get { return _UserType; }
			set { _UserType = value; }
		}


		public string FirstName
		{
			get { return _FirstName; }
			set { _FirstName = value; }
		}


		public string LastName
		{
			get { return _LastName; }
			set { _LastName = value; }
		}


		public int CustomerTypeid
		{
			get { return _CustomerTypeid; }
			set { _CustomerTypeid = value; }
		}

		public string UserGuid
		{
			get { return _userGuid; }
			set { _userGuid = value; }
		}

		public string Gender
		{
			get { return _Gender; }
			set { _Gender = value; }
		}
		public List<AccountBase> Userlist
		{
			get { return _Userlist; }
			set { _Userlist = value; }
		}



		public bool IsActive
		{
			get { return _IsActive; }
			set { _IsActive = value; }
		}



		public bool IsEmailVerify
		{
			get { return _IsEmailVerify; }
			set { _IsEmailVerify = value; }
		}




		public bool IsDelete
		{
			get { return _IsDelete; }
			set { _IsDelete = value; }
		}

		public bool IsMobileVerify
		{
			get { return _IsMobileVerify; }
			set { _IsMobileVerify = value; }
		}


		public Int64 UserId
		{
			get { return _UserId; }
			set { _UserId = value; }
		}



		public bool AccountUpdate
		{
			get { return _AccountUpdate; }
			set { _AccountUpdate = value; }
		}



		public bool EmailUpdate
		{
			get { return _EmailUpdate; }
			set { _EmailUpdate = value; }
		}



		public bool DeleteAccount
		{
			get { return _DeleteAccount; }
			set { _DeleteAccount = value; }
		}



		public bool MobileUpdate
		{
			get { return _MobileUpdate; }
			set { _MobileUpdate = value; }
		}



		public string OldPassword
		{
			get { return _OldPassword; }
			set { _OldPassword = value; }
		}

		public string Email
		{
			get { return _Email; }
			set { _Email = value; }
		}



		public string NewPassword
		{
			get { return _NewPassword; }
			set { _NewPassword = value; }
		}

		public string ProviderType
		{
			get { return _providerType; }
			set { _providerType = value; }
		}
		public string ProviderId
		{
			get { return _providerId; }
			set { _providerId = value; }
		}
		#endregion
	}

	public class AddtoCartItem
	{
		#region Declarations



		private int _id = 0;
		private string _ipaddress = string.Empty;
		private string _OrderWithUsXml = string.Empty;
		private string _OrderWithUsReciept = string.Empty;
		#endregion
		#region Properties

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		public string Ipaddress
		{
			get { return _ipaddress; }
			set { _ipaddress = value; }
		}
		public string OrderWithUsXml
		{
			get { return _OrderWithUsXml; }
			set { _OrderWithUsXml = value; }
		}
		public string OrderWithUsReciept
		{
			get { return _OrderWithUsReciept; }
			set { _OrderWithUsReciept = value; }
		}

		#endregion
	}
}
