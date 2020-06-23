using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace MGAChargerEcommerce.Models
{
    public class UsersContext : DbContext
    {
        //public UsersContext()
        //    : base("DefaultConnection")
        //{
        //}

        //public DbSet<UserProfile> UserProfiles { get; set; }
    }

	[Table("UserProfile")]
	public class UserProfile
	{
		[Key]
		[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
		public int UserId { get; set; }
		public string UserName { get; set; }
	}

	public class RegisterExternalLoginModel
	{
		[Required]
		[Display(Name = "User name")]
		public string UserName { get; set; }

		public string ExternalLoginData { get; set; }
	}

	public class LocalPasswordModel
	{
		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "Current password")]
		public string OldPassword { get; set; }

		[Required]
		[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
		[DataType(DataType.Password)]
		[Display(Name = "New password")]
		public string NewPassword { get; set; }

		[DataType(DataType.Password)]
		[Display(Name = "Confirm new password")]
		[Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; }
	}

	public class LoginModel
	{
		[Required(ErrorMessage = "Please Enter Email.")]
		[Display(Name = "User name")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Please Enter Password.")]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; }

		[Display(Name = "Remember me?")]
		public bool RememberMe { get; set; }


	}

	//public class RegisterModel
	//{


	//    [Required]
	//    [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
	//    [DataType(DataType.Password)]
	//    [Display(Name = "Password")]
	//    public string Password { get; set; }

	//    [DataType(DataType.Password)]
	//    [Display(Name = "Confirm password")]
	//    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
	//    public string ConfirmPassword { get; set; }
	//}

	public class ExternalLogin
	{
		public string Provider { get; set; }
		public string ProviderDisplayName { get; set; }
		public string ProviderUserId { get; set; }
	}

	public class RegisterModel
	{

		public int id { get; set; }
		public bool emailstatus { get; set; }
		public bool mobilestatus { get; set; }
		public bool accountstatus { get; set; }

        [Required(ErrorMessage = "Please enter Email Address.")]
		[Display(Name = "User name")]
		public string UserName { get; set; }

		public string OldEmail { get; set; }

		[Required(ErrorMessage = "Please enter Email Id")]
		[Display(Name = "Email Id")]
		//[EmailAddress(ErrorMessage = "Please enter valid Email Id")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Please enter Password")]
		[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Please enter Confirm Password")]
		[DataType(DataType.Password)]
		[Display(Name = "Confirm Password")]
		[System.Web.Mvc.Compare("Password", ErrorMessage = "The password and confirmation password does not match.")]
		public string ConfirmPassword { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "Current password")]
		public string OldPassword { get; set; }



		public string role { get; set; }
		public string createddate { get; set; }



		[Required(ErrorMessage = "Please enter Mobile Number")]
		[StringLength(10, ErrorMessage = "The {0} must be 10 Digit.", MinimumLength = 10)]
		[Display(Name = "Mobile Number")]
		public string MobileNo { get; set; }

		[Required(ErrorMessage = "Please enter Address")]
		[Display(Name = "Address")]
		public string Address { get; set; }

		[Required(ErrorMessage = "Please Choose UserType")]
		[Display(Name = "Role")]
		public int UserType { get; set; }

		[Required(ErrorMessage = "Please enter First Name")]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		// [Required(ErrorMessage = "Please Enter Last Name")]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		[Required(ErrorMessage = "User Type is required.")]
		public int CustomerTypeid { get; set; }

		public List<System.Web.Mvc.SelectListItem> citylist { get; set; }
		public List<System.Web.Mvc.SelectListItem> statelist { get; set; }

		public Int64 Userid { get; set; }

		public bool IsActive { get; set; }
		public bool IsEmailVerify { get; set; }
		public bool IsMobileVerify { get; set; }
		public bool IsDelete { get; set; }

		public string UserTypeName { get; set; }

		[Required(ErrorMessage = "Please Choose Date of Birth")]
		[Display(Name = "Date of Birth")]
		[DataType(DataType.DateTime, ErrorMessage = "Please enter Valid Datetime")]
		public string dob { get; set; }


		[Required(ErrorMessage = "Please Select City")]
		[Display(Name = "City")]
		public string City { get; set; }


		[Required(ErrorMessage = "Please Select State")]
		[Display(Name = "State")]
		public string State { get; set; }


		[Required(ErrorMessage = "Please enter Zip Code")]
		[Display(Name = "ZipCode")]
		public string ZipCode { get; set; }
	} 
}
