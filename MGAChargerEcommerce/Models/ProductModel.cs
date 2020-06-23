using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MGAChargerEcommerce.Models
{
	public class ManageProduct
	{
		public int ProductId { get; set; }
        public int Productqty { get; set; }
		public string ProductCode { get; set; }
		public string ProductName { get; set; }
		public int ProductCategory { get; set; }
		public string ProductDescription { get; set; }
		public string ProductReturnPolicy { get; set; }
		public string OfferDescription { get; set; }
		public string ProductImage { get; set; }

        
        public string ProductImageSideView { get; set; }
        public string ProductImageTopView { get; set; }
        public string ProductImageBottomView { get; set; }
        public string ProductDetailImage { get; set; }
        
		public decimal ProductRate { get; set; }
		public decimal SubTotalAmount { get; set; }
		public decimal CGSTAmount { get; set; }
		public decimal SGSTAmount { get; set; }
		public decimal IGSTAmount { get; set; }
		public decimal TotalTax { get; set; }
		public decimal TotalAmountIncludeTax { get; set; }

		public List<ManageProduct> ManageProductlist { get; set; }
	}

	public class cartmodel
	{
		public string product { get; set; }
		public string amount { get; set; }
		public int quantity { get; set; }
		public string discount { get; set; }
		public string RemoveBookList { get; set; }
	}

	

	public class DiscountModel
	{
		public int DiscountId { get; set; }
		public decimal Discount { get; set; }
		public decimal Amount1 { get; set; }
		public decimal Amount2 { get; set; }
		[Display(Name = "Status")]
		public bool IsActive { get; set; }

	}
	public class ManageDiscountModel
	{
		public List<DiscountModel> Discountlist { get; set; }
	}

	public class CategoryModel
	{
		public int CategoryId { get; set; }

		[Required(ErrorMessage = "Please Enter Category Name")]
		[Display(Name = "Category Name")]
		[MaxLength(500, ErrorMessage = "Only 500 characters Required")]
		public string CategoryName { get; set; }
		[Required(ErrorMessage = "Please Enter Features")]
		public string Features { get; set; }

		[Display(Name = "BookType")]
		[Required(ErrorMessage = "Please Select Booktype")]
		public int Id { get; set; }

		[Display(Name = "Image")]
		public string BookImage { get; set; }
		public string CreatedOn { get; set; }
		public int CreatedBy { get; set; }
		public bool IsDeleted { get; set; }
		[Display(Name = "Status")]
		public bool IsActive { get; set; }
	}

	public class ManageCategory
	{
		public CategoryModel category { get; set; }
		public List<CategoryModel> categoryList { get; set; }
	}

	public class UserHistory
	{
		public int Id { get; set; }
		public int Quantity { get; set; }
		public string Product { get; set; }
		public string Type { get; set; }
		public string Price { get; set; }
		public string Name { get; set; }
		public string ImageUrl { get; set; }
		public string Total { get; set; }
		public string Discount { get; set; }
		public DateTime OrderDate { get; set; }
		public string DeliveryAddress { get; set; }
		public string DeliveryContact { get; set; }
	}

   
}