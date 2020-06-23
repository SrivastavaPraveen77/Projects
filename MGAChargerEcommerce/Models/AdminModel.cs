using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MGAChargerEcommerce.Models
{
	public class MasterPagesModel
	{
		public int PageId { get; set; }
		public string PageName { get; set; }
		[Display(Name = "Content")]
		[Required(ErrorMessage = "Page Content is Required..!")]
		public string HtmlContent { get; set; }
		public List<MasterPagesModel> MasterPagesModelList { get; set; }
	}

    public class HomeAboutusModel
    {
        public int PageId { get; set; }
        public string PageName { get; set; }
        [Display(Name = "Content")]
        [Required(ErrorMessage = "Page Content is Required..!")]
        public string HtmlContent { get; set; }
        public List<MasterPagesModel> MasterPagesModelList { get; set; }
       
    }


	public class PhotoGallery
	{
		public int ID { get; set; }

		[Required(ErrorMessage = "Please Enter Event Name")]
		[Display(Name = "Title")]
		public string EventName { get; set; }

		
		[Display(Name = "Description")]
		public string EventDescription { get; set; }

		[Display(Name = "Upload Photo")]
		public string EventImage { get; set; }
	}

	public class ManagePhotoGallery
	{
		public PhotoGallery photoGallery { get; set; }
		public List<PhotoGallery> photoGalleryList { get; set; }
	}

	public class PrestigiousCustomer
	{
		public int ID { get; set; }

		[Required(ErrorMessage = "Please Enter Event Name")]
		[Display(Name = "Event Name")]
		public string EventsName { get; set; }

        
        [Display(Name = "Event URL")]
        public string URL { get; set; }


		[Display(Name = "Upload Photo")]
		public string Image { get; set; }
	}

    public class OurClient
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please Enter Client Name")]
        [Display(Name = "Client Name")]
        public string ClientName { get; set; }

        [Display(Name = "Upload Photo")]
        public string Image { get; set; }
    }


	public class ManagePrestigiousCustomer
	{
		public PrestigiousCustomer prestigiousCustomer { get; set; }
		public List<PrestigiousCustomer> prestigiousCustomerList { get; set; }
	}

    public class ManageOurClient
    {
        public OurClient ourClient { get; set; }
        public List<OurClient> ourClientList { get; set; }
    }

	public class ContactUs
	{
		public int ID { get; set; }


		[Display(Name = "Customer Care Contact No.")]
		public string CustomerCareNumber { get; set; }


		[Display(Name = "Sales Support No.")]
		public string SalesSupportNumber { get; set; }

		[Display(Name = "Customer Care Email Address.")]
		public string CustomerCareEmailAddress { get; set; }

		[Display(Name = "Address")]
		public string Address { get; set; }

		[Display(Name = "AboutUs")]
		public string AboutUs { get; set; }
	}

	
    public class AddProduct
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please Enter Product Code.")]
        [Display(Name = "Product Code")]
        public string ProductCode { get; set; }

        [Required(ErrorMessage = "Please Enter Product Name.")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please Select product Category.")]
        [Display(Name = "Product Category")]
        public int ProductCategory { get; set; }

        [Required(ErrorMessage = "Please Enter Product Order.")]
        [Display(Name = "Product Order")]
        public int ProductOrder { get; set; }

        [Display(Name = "Product Description")]
        public string ProductDescription { get; set; }

        [Display(Name = "Product Return Policy")]
        public string ProductReturnPolicy { get; set; }

        [Required(ErrorMessage = "Please Select product rate.")]
        [Display(Name = "Product Rate")]
        public decimal ProductRate { get; set; }

        [Display(Name = "Offer Description")]
        public string OfferDescription { get; set; }


        [Required(ErrorMessage = "Please Select SubTotal Amount.")]
        [Display(Name = "Subtotal Amount (INR)")]
        public decimal SubTotalAmount { get; set; }

        [Required(ErrorMessage = "Please Enter CGST %.")]
        [Display(Name = "CGST%")]
        public decimal CGSTPercentage { get; set; }

        [Required(ErrorMessage = "Please Enter CGST Amount (INR).")]
        [Display(Name = "CGST Amount (INR)")]
        public decimal CGSTAmount { get; set; }

        [Required(ErrorMessage = "Please Enter SGST %.")]
        [Display(Name = "SGST %")]
        public decimal SGSTPercentage { get; set; }

        [Required(ErrorMessage = "Please Enter SGST Amount (INR).")]
        [Display(Name = "SGST Amount(INR)")]
        public decimal SGSTAmount { get; set; }


        [Required(ErrorMessage = "Please Enter SGST %.")]
        [Display(Name = "IGST %")]
        public decimal IGSTPercentage { get; set; }

        [Required(ErrorMessage = "Please Enter IGST Amount (INR).")]
        [Display(Name = "IGST Amount(INR)")]
        public decimal IGSTAmount { get; set; }

        [Required(ErrorMessage = "Please Enter Total Amount Include Tax (INR).")]
        [Display(Name = "Total Amount Include Tax (INR)")]
        public decimal TotalAmountIncludeTax { get; set; }

        [Display(Name = "Upload Photo")]
        public string ProductImage { get; set; }

        [Display(Name = "Side View")]
        public string ProductImageSideView { get; set; }

        [Display(Name = "Top View")]
        public string ProductImageTopView { get; set; }

        [Display(Name = "Bottom View")]
        public string ProductImageBottomView { get; set; }

        [Display(Name = "Detail Image")]
        public string ProductImageDetail { get; set; }

    }

	public class ManageAddProduct
	{
		public AddProduct Addproduct { get; set; }
		public List<AddProduct> ProductList { get; set; }
	}

	public class ShipingDetail
	{
		public int ShippingId { get; set; }

		[Required(ErrorMessage = "Please Enter Source Name.")]
		[Display(Name = "Source Name")]
		public string SourceName { get; set; }

		[Required(ErrorMessage = "Please Enter State.")]
		[Display(Name = "State")]
		//public int StateId { get; set; }
		public string StateName { get; set; }

		[Required(ErrorMessage = "Please Enter CourierName.")]
		[Display(Name = "CourierName")]
		public string CourierName { get; set; }

		[Required(ErrorMessage = "Please Enter Product.")]
		[Display(Name = "Product")]
		public string Product { get; set; }

		[Required(ErrorMessage = "Please Enter CourierCategory.")]
		[Display(Name = "CourierCategory")]
		public string CourierCategory { get; set; }

		[Required(ErrorMessage = "Please Enter CourierCharge.")]
		[Display(Name = "CourierCharge")]
		public decimal CourierCharge { get; set; }

		[Required(ErrorMessage = "Please Enter ProductDimensioon.")]
		[Display(Name = "ProductDimensioon")]
		public string ProductDimensioon { get; set; }

		[Required(ErrorMessage = "Please Enter ProdctWeight.")]
		[Display(Name = "ProdctWeight(in Kg)")]
		public decimal ProdctWeight { get; set; }
		public int CreatedBy { get; set; }
		public int UpdatedBy { get; set; }





	}

	public class ShipingDetailNew
	{
		public int ShippingId { get; set; }

		[Required(ErrorMessage = "Please Enter Source Name.")]
		[Display(Name = "Source Name")]
		public string SourceName { get; set; }

		[Required(ErrorMessage = "Please Enter State.")]
		[Display(Name = "State")]
		public string StateName { get; set; }

		[Required(ErrorMessage = "Please Enter CourierName.")]
		[Display(Name = "CourierName")]
		public string CourierName { get; set; }

		[Required(ErrorMessage = "Please Enter Product.")]
		[Display(Name = "Product")]
		public string ProductName { get; set; }

		[Required(ErrorMessage = "Please Enter CourierCategory.")]
		[Display(Name = "CourierCategory")]
		public string CourierCategory { get; set; }

		[Required(ErrorMessage = "Please Enter CourierCharge.")]
		[Display(Name = "CourierCharge")]
		public decimal CourierCharges { get; set; }

		[Required(ErrorMessage = "Please Enter ProductDimensioon.")]
		[Display(Name = "ProductDimensioon")]
		public string ProductDimension { get; set; }

		[Required(ErrorMessage = "Please Enter ProdctWeight.")]
		[Display(Name = "ProdctWeight")]
		public decimal Weight { get; set; }


	}

	public class ManageShipingDetail
	{
		public ShipingDetail shipingDetail { get; set; }
		public List<ShipingDetail> shipingDetailList { get; set; }
	}

	public class EnquieryDetail
	{
		public int Id { get; set; }
		public string InquiryNo { get; set; }

		public string Type { get; set; }
		public string CustomerName { get; set; }

		public string CustomerEmail { get; set; }

		public string Subject { get; set; }

		public string Message { get; set; }
		public DateTime CreatedOn { get; set; }
	}

	public class EnquieryDetailModel
	{
		public List<EnquieryDetail> EnquieryDetailList { get; set; }
	}

	public class ComplaintDetail
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Please Enter ComplaintNo.")]
		[Display(Name = "ComplaintNo")]
		public string ComplaintNo { get; set; }

		[Required(ErrorMessage = "Please Enter Customer Name.")]
		[Display(Name = "Customer Name")]
		public string CustomerName { get; set; }

		[Required(ErrorMessage = "Please Enter Customer Email.")]
		[Display(Name = "Customer Email")]
		public string CustomerEmail { get; set; }



		[Required(ErrorMessage = "Please Enter DealerName.")]
		[Display(Name = "DealerName")]
		public string DealerName { get; set; }

		[Required(ErrorMessage = "Please Enter InvoiceNo.")]
		[Display(Name = "InvoiceNo")]
		public string InvoiceNo { get; set; }

		[Required(ErrorMessage = "Please Enter Purchase Date.")]
		[Display(Name = "Purchase Date")]
		public DateTime PurchaseDate { get; set; }

		[Required(ErrorMessage = "Please Enter Product Serial.")]
		[Display(Name = "Product Serial")]
		public string ProductSerialNo { get; set; }

		[Required(ErrorMessage = "Please Enter Modal No.")]
		[Display(Name = "Modal No.")]
		public string ModalNo { get; set; }


		[Required(ErrorMessage = "Please Enter Complaint.")]
		[Display(Name = "Complaint.")]
		public string Complaint { get; set; }


		[Display(Name = "Status.")]
		public string Status { get; set; }

		[Display(Name = "Remark.")]
		public string Remark { get; set; }
		public String ContactNo { get; set; }
		public String Type { get; set; }
		public DateTime Date { get; set; }
		public int CreatedBy { get; set; }
		public int UpdatedBy { get; set; }


	}

	public class ComplaintDetailModel
	{
		public ComplaintDetail complainDetail { get; set; }
		public List<ComplaintDetail> ComplainDetailList { get; set; }
	}

    public class MyOrderDetail
    {
        public int OrderId { get; set; }

        public String OrderNumber { get; set; }
        public String Txid { get; set; }
        public String UserEmail { get; set; }
        public String ShipingTo { get; set; }
        public String GrandTotalAmount { get; set; }
        public String status { get; set; }

        public String ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ShippingCharges { get; set; }
        public decimal Quantity { get; set; }

        public String FirstName { get; set; }
        public String LastName { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PinCode { get; set; }

        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingCountry { get; set; }

        public DateTime OrderDate { get; set; }

        public string BName { get; set; }
        public string BAddress { get; set; }
        public string BCity { get; set; }

        public string BState { get; set; }

        public string BCountry { get; set; }
        public string BPinCode { get; set; }
        public string BPhoneNo { get; set; }



        public string DName { get; set; }
        public string DAddress { get; set; }
        public string DCity { get; set; }

        public string DState { get; set; }
        public string DCountry { get; set; }
        public string DPinCode { get; set; }
        public string DPhoneNo { get; set; }

        public decimal DisCountAmount { get; set; }
        

    }

	public class MyOrderDetailModel
	{
		public List<MyOrderDetail> myOrderDetailList { get; set; }
	}

    public class CityModel
    {
        public int StateId { get; set; }
    }
    #region CouponGenerationModel
    public class CustomerCoupon
    {
        public int CustomerCouponID { get; set; }

        [Required(ErrorMessage = "Please Enter Coupon Coupon."),MinLength(6),MaxLength(16)]
        [Display(Name = "Coupon Code"),Editable(false)]
        public string CouponCode { get; set; }

        
        [Display(Name = "isCustom")]
        public bool? isCustom { get; set; }

        [Required(ErrorMessage = "Please Select Customer.")]
        [Display(Name = "Customer")]
        public int? CustomerId { get; set; }
        [Required(ErrorMessage = "Please Select Customer.")]
        [Display(Name = "Customer")]
        public string CustomerName{ get; set; }

        [Required(ErrorMessage = "Please Select Validity Date.")]
        [Display(Name = "Expired On")]
        public DateTime? ExpiredOn { get; set; }

        [Required(ErrorMessage = "Please Discount Type.")]
        [Display(Name = "Discount Type")]
        public string DiscountType { get; set; }

        [Required(ErrorMessage = "Please Enter Discount.")]
        [Display(Name = "Discount")]
        public decimal? Discount { get; set; }

        [Required(ErrorMessage = "Please Enter Remarks."),MaxLength(200)]
        [Display(Name = "Remarks")]
        public string Remarks { get; set; }        
        public bool? isUsed { get; set; }
        public DateTime? UsedOn { get; set; }
        public int? UsedBy { get; set; }
        public bool? IsDeactive { get; set; }

        [Display(Name = "Min Purchase Amount")]
        public double? MinPurchaseAmount { get; set; }

    }
    #endregion
}