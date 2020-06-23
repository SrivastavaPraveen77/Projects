using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGA.Base.Admin
{
	public class ManagePages
	{
		private int _pageId;
		private string _pageName = string.Empty;
		private string _htmlContent = string.Empty;
		private bool _isActive = false;


		public int PageId
		{
			get { return _pageId; }
			set { _pageId = value; }
		}

		public string PageName
		{
			get { return _pageName; }
			set { _pageName = value; }
		}

		public string HtmlContent
		{
			get { return _htmlContent; }
			set { _htmlContent = value; }
		}

		public bool IsActive
		{
			get { return _isActive; }
			set { _isActive = value; }
		}


	}

	public class PhotoGalleryBase
	{
		private int _ID = 0;
		private string _EventName = string.Empty;
		private string _EventDescription = string.Empty;
		private string _EventImage = string.Empty;
		private DateTime? _CreatedOn = null;
		private int _createdBy = 0;

		public string EventName { get { return _EventName; } set { _EventName = value; } }
		public string EventDescription { get { return _EventDescription; } set { _EventDescription = value; } }

		public string EventImage { get { return _EventImage; } set { _EventImage = value; } }

		public DateTime? CreatedOn { get { return _CreatedOn; } set { _CreatedOn = value; } }

		public int CreatedBy { get { return _createdBy; } set { _createdBy = value; } }

		public int ID { get { return _ID; } set { _ID = value; } }

	}

	public class PrestigiousCustomerBase
	{
		private int _ID = 0;
		private string _EventName = string.Empty;
        private string _EventUrl = string.Empty;
		private string _Image = string.Empty;
		private DateTime? _CreatedOn = null;
		private int _createdBy = 0;

        public string EventName { get { return _EventName; } set { _EventName = value; } }

        public string EventUrl { get { return _EventUrl; } set { _EventUrl = value; } }
		public string Image { get { return _Image; } set { _Image = value; } }

		public DateTime? CreatedOn { get { return _CreatedOn; } set { _CreatedOn = value; } }

		public int CreatedBy { get { return _createdBy; } set { _createdBy = value; } }

		public int ID { get { return _ID; } set { _ID = value; } }

	}

	public class ContactUsBase
	{
		private int _ID = 0;
		private string _CustomerCareNumber = string.Empty;
		private string _CustomerSalesSupportNumber = string.Empty;
		private string _EmailAddress = string.Empty;
		private string _Address = string.Empty;
		private string _AboutUs = string.Empty;
		private DateTime? _CreatedOn = null;
		private int _createdBy = 0;

		public string CustomerCareNumber { get { return _CustomerCareNumber; } set { _CustomerCareNumber = value; } }
		public string CustomerSalesSupportNumber { get { return _CustomerSalesSupportNumber; } set { _CustomerSalesSupportNumber = value; } }

		public string EmailAddress { get { return _EmailAddress; } set { _EmailAddress = value; } }

		public string Address { get { return _Address; } set { _Address = value; } }

		public string AboutUs { get { return _AboutUs; } set { _AboutUs = value; } }

		public DateTime? CreatedOn { get { return _CreatedOn; } set { _CreatedOn = value; } }

		public int CreatedBy { get { return _createdBy; } set { _createdBy = value; } }

		public int ID { get { return _ID; } set { _ID = value; } }

	}

    public class AddProductBase
    {
        private int _productId;
        private string _productCode = string.Empty;
        private string _productName = string.Empty;
        private int _productCategory;
        private int _productOrder;
        private string _productDescription = string.Empty;
        private string _productReturnPolicy = string.Empty;
        private decimal _ProductRate;
        private string _offerDescription = string.Empty;
        private decimal _subTotalAmount;
        private decimal _cgstPercentage;
        private decimal _cgstAmount;
        private decimal _sgstPercentage;
        private decimal _sgstAmount;
        private decimal _igstPercentage;
        private decimal _igstAmount;
        private decimal _totalAmountIncludeTax;
        private string _productImage = string.Empty;

        private string _productImageSideView = string.Empty;
        private string _productImageTopView = string.Empty;
        private string _productImageBottomView = string.Empty;
        private string _productImageDetail = string.Empty;


        private int _createdBy;
        private int _updatedBy;

        public int ProductId { get { return _productId; } set { _productId = value; } }
        public string ProductCode { get { return _productCode; } set { _productCode = value; } }

        public string ProductName { get { return _productName; } set { _productName = value; } }
        public int ProductCategory { get { return _productCategory; } set { _productCategory = value; } }

        public int ProductOrder { get { return _productOrder; } set { _productOrder = value; } }
        public string ProductDescription { get { return _productDescription; } set { _productDescription = value; } }
        public string ProductReturnPolicy { get { return _productReturnPolicy; } set { _productReturnPolicy = value; } }
        public decimal ProductRate { get { return _ProductRate; } set { _ProductRate = value; } }

        public string OfferDescription { get { return _offerDescription; } set { _offerDescription = value; } }

        public decimal SubTotalAmount { get { return _subTotalAmount; } set { _subTotalAmount = value; } }


        public decimal CGSTPercentage { get { return _cgstPercentage; } set { _cgstPercentage = value; } }
        public decimal CGSTAmount { get { return _cgstAmount; } set { _cgstAmount = value; } }
        public decimal SGSTPercentage { get { return _sgstPercentage; } set { _sgstPercentage = value; } }
        public decimal SGSTAmount { get { return _sgstAmount; } set { _sgstAmount = value; } }

        public decimal IGSTPercentage { get { return _igstPercentage; } set { _igstPercentage = value; } }

        public decimal IGSTAmount { get { return _igstAmount; } set { _igstAmount = value; } }

        public decimal TotalAmountIncludeTax { get { return _totalAmountIncludeTax; } set { _totalAmountIncludeTax = value; } }

        public string ProductImage { get { return _productImage; } set { _productImage = value; } }

        public string ProductImageSideView { get { return _productImageSideView; } set { _productImageSideView = value; } }
        public string ProductImageTopView { get { return _productImageTopView; } set { _productImageTopView = value; } }
        public string ProductImageBottom { get { return _productImageBottomView; } set { _productImageBottomView = value; } }
        public string ProductImageDetail { get { return _productImageDetail; } set { _productImageDetail = value; } }


        public int CreatedBy { get { return _createdBy; } set { _createdBy = value; } }

        public int UpdatedBy { get { return _updatedBy; } set { _updatedBy = value; } }



    }

	public class ShippingDetailBase
	{
		private int _Action = 0;
		private int _ShippingID = 0;
		private string _SourceName = string.Empty;
		//private int _StateId = 0;
		private string _StateName = string.Empty;
		private string _CourierName = string.Empty;
		public string _ProductName = string.Empty;

		private string _CourierCategory = string.Empty;
		private decimal _CourierCharge = 0;
		private string _ProductDimensioon = string.Empty;
		private decimal _ProdctWeight = 0;

		private int _CreatedBy = 0;
		private int _UpdatedBy = 0;


		public int Action { get { return _Action; } set { _Action = value; } }
		public int ShippingID { get { return _ShippingID; } set { _ShippingID = value; } }

		public string SourceName { get { return _SourceName; } set { _SourceName = value; } }

		//public int StateId { get { return _StateId; } set { _StateId = value; } }
		public string StateName { get { return _StateName; } set { _StateName = value; } }

		public string CourierName { get { return _CourierName; } set { _CourierName = value; } }

		public string ProductName { get { return _ProductName; } set { _ProductName = value; } }

		public string CourierCategory { get { return _CourierCategory; } set { _CourierCategory = value; } }

		public decimal CourierCharge { get { return _CourierCharge; } set { _CourierCharge = value; } }

		public string ProductDimension { get { return _ProductDimensioon; } set { _ProductDimensioon = value; } }
		public decimal ProdctWeight { get { return _ProdctWeight; } set { _ProdctWeight = value; } }


		public int CreatedBy { get { return _CreatedBy; } set { _CreatedBy = value; } }

		public int UpdatedBy { get { return _UpdatedBy; } set { _UpdatedBy = value; } }



	}

	public class EnquieryDetailBase
	{
		private int _Action = 0;
		private string _InquireyNo = string.Empty;
		private string _Type = string.Empty;

		private string _CustomerName = string.Empty;

		private string _CustomerEmail = string.Empty;

		private string _Subject = string.Empty;
		private string _Message = string.Empty;
		private DateTime _CreatedOn;
		private int _CreatedBy = 0;


		public int Action { get { return _Action; } set { _Action = value; } }
		public string InquireyNo { get { return _InquireyNo; } set { _InquireyNo = value; } }

		public string Type { get { return _Type; } set { _Type = value; } }
		public string CustomerName { get { return _CustomerName; } set { _CustomerName = value; } }

		public string CustomerEmail { get { return _CustomerEmail; } set { _CustomerEmail = value; } }

		public string Subject { get { return _Subject; } set { _Subject = value; } }

		public string Message { get { return _Message; } set { _Message = value; } }
		public DateTime CreatedOn { get { return _CreatedOn; } set { _CreatedOn = value; } }

		public int CreatedBy { get { return _CreatedBy; } set { _CreatedBy = value; } }

	}

	public class ComplaintDetailBase
	{
		private int _Action = 0;
		private int _Id = 0;
		private string _ComplaintNo = string.Empty;
		private string _Type = string.Empty;
		private string _Date = string.Empty;
		private string _CustomerName = string.Empty;
		private string _CustomerEmail = string.Empty;
		private string _CustomerContact = string.Empty;
		private string _Status = string.Empty;
		public string _DealerName = string.Empty;
		public string _InvoiceNo = string.Empty;
		public DateTime _PurchaseDate;
		public string _ProductSerial = string.Empty;
		public string _ModalNo = string.Empty;
		public string _Complaint = string.Empty;
		public string _UpdateStatus { get; set; }
		public string _Addremark { get; set; }
		private int _CreatedBy = 0;

		private int _ModifyBy = 0;


		public int Action { get { return _Action; } set { _Action = value; } }

		public int Id { get { return _Action; } set { _Action = value; } }
		public string ComplaintNo { get { return _ComplaintNo; } set { _ComplaintNo = value; } }

		public string Type { get { return _Type; } set { _Type = value; } }
		public string Date { get { return _Date; } set { _Date = value; } }
		public string CustomerName { get { return _CustomerName; } set { _CustomerName = value; } }
		public string CustomerEmail { get { return _CustomerEmail; } set { _CustomerEmail = value; } }

		public string CustomerContact { get { return _CustomerContact; } set { _CustomerContact = value; } }
		public string Status { get { return _Status; } set { _Status = value; } }

		public int CreatedBy { get { return _CreatedBy; } set { _CreatedBy = value; } }

		public int ModifyBy { get { return _ModifyBy; } set { _ModifyBy = value; } }

		public string DealerName { get { return _DealerName; } set { _DealerName = value; } }
		public string InvoiceNo { get { return _InvoiceNo; } set { _InvoiceNo = value; } }

		public DateTime PurchaseDate { get { return _PurchaseDate; } set { _PurchaseDate = value; } }

		public string ProductSerial { get { return _ProductSerial; } set { _ProductSerial = value; } }

		public string ModalNo { get { return _ModalNo; } set { _ModalNo = value; } }

		public string Complaint { get { return _Complaint; } set { _Complaint = value; } }

		public string UpdateStatus { get { return _UpdateStatus; } set { _UpdateStatus = value; } }

		public string Addremark { get { return _Addremark; } set { _Addremark = value; } }

	}


}
