using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MGA.BASE.Home
{
	public class ProductBase
	{
		private int _action = 0;
		private int _productId = 0;
		private string _productCode = string.Empty;
		private string _productName = string.Empty;
		private int _productCategory = 0;
		private string _productDescription = string.Empty;
		private string _productReturnPolicy = string.Empty;
		private string _offerDescription = string.Empty;
		private string _productImage = string.Empty;
		private decimal _productRate = 0;
		private decimal _subTotalAmount = 0;
		private decimal _cGSTAmount = 0;
		private decimal _sGSTAmount = 0;
		private decimal _iGSTAmount = 0;
		private decimal _totalTax = 0;
		private decimal _totalAmountIncludeTax = 0;

		public int ActionId { get { return _action; } set { _action = value; } }
		public int ProductId { get { return _productId; } set { _productId = value; } }
		public string productCode { get { return _productCode; } set { _productCode = value; } }
		public string ProductName { get { return _productName; } set { _productName = value; } }
		public int ProductCategory { get { return _productCategory; } set { _productCategory = value; } }
		public string ProductDescription { get { return _productDescription; } set { _productDescription = value; } }
		public string ProductReturnPolicy { get { return _productReturnPolicy; } set { _productReturnPolicy = value; } }
		public string OfferDescription { get { return _offerDescription; } set { _offerDescription = value; } }
		public string ProductImage { get { return _productImage; } set { _productImage = value; } }
		public decimal ProductRate { get { return _productRate; } set { _productRate = value; } }
		public decimal SubTotalAmount { get { return _subTotalAmount; } set { _subTotalAmount = value; } }
		public decimal CGSTAmount { get { return _cGSTAmount; } set { _cGSTAmount = value; } }
		public decimal SGSTAmount { get { return _sGSTAmount; } set { _sGSTAmount = value; } }
		public decimal IGSTAmount { get { return _iGSTAmount; } set { _iGSTAmount = value; } }
		public decimal TotalTax { get { return _totalTax; } set { _totalTax = value; } }
		public decimal TotalAmountIncludeTax { get { return _totalAmountIncludeTax; } set { _totalAmountIncludeTax = value; } }

	}

	public class CheckoutBase
	{
		private int _action = 0;
		private int _orderId = 0;
		private string _txid = string.Empty; 
		private int _userId = 0;
		private decimal _totalOrderAmount = 0;
		private decimal _discountAmount = 0;
		private decimal _cODCharges = 0;
		private decimal _grandTotalAmount = 0;
		private int _paymentMode = 0;
		private decimal _vAT = 0;
		private decimal _serviceTax = 0;
		private string _aWBNumber = string.Empty;
		private string _bname = string.Empty;
		private string _bemail = string.Empty;
		private string _bphoneNo = string.Empty;
		private string _bState = string.Empty;
		private string _bCity = string.Empty;
		private string _bAddress = string.Empty;
		private string _bPincode = string.Empty;
		private string _dname = string.Empty;
		private string _demail = string.Empty;
		private string _dphoneNo = string.Empty;
		private string _dState = string.Empty;
		private string _dCity = string.Empty;
		private string _dAddress = string.Empty;
		private string _dPincode = string.Empty;
		private string _transactionStatus = string.Empty;

		public int Action { get { return _action; } set { _action = value; } }
		public int OrderId { get { return _orderId; } set { _orderId = value; } }
		public string TxId { get { return _txid; } set { _txid = value; } } 
		public int UserId { get { return _userId; } set { _userId = value; } }
		public decimal TotalOrderAmount { get { return _totalOrderAmount; } set { _totalOrderAmount = value; } }
		public decimal DiscountAmount { get { return _discountAmount; } set { _discountAmount = value; } }
		public decimal CODCharges { get { return _cODCharges; } set { _cODCharges = value; } }
		public decimal GrandTotalAmount { get { return _grandTotalAmount; } set { _grandTotalAmount = value; } }
		public int PaymentMode { get { return _paymentMode; } set { _paymentMode = value; } }
		public decimal VAT { get { return _vAT; } set { _vAT = value; } }
		public decimal ServiceTax { get { return _serviceTax; } set { _serviceTax = value; } }
		public string AWBNumber { get { return _aWBNumber; } set { _aWBNumber = value; } }

		public string BName { get { return _bname; } set { _bname = value; } }
		public string BEmail { get { return _bemail; } set { _bemail = value; } }
		public string BPhoneNo { get { return _bphoneNo; } set { _bphoneNo = value; } }
		public string BState { get { return _bState; } set { _bState = value; } }
		public string BCity { get { return _bCity; } set { _bCity = value; } }
		public string BAddress { get { return _bAddress; } set { _bAddress = value; } }
		public string BPinCode { get { return _bPincode; } set { _bPincode = value; } }

		public string DName { get { return _dname; } set { _dname = value; } }
		public string DEmail { get { return _demail; } set { _demail = value; } }
		public string DPhoneNo { get { return _dphoneNo; } set { _dphoneNo = value; } }
		public string DState { get { return _dState; } set { _dState = value; } }
		public string DCity { get { return _dCity; } set { _dCity = value; } }
		public string DAddress { get { return _dAddress; } set { _dAddress = value; } }
		public string DPinCode { get { return _dPincode; } set { _dPincode = value; } }
        public string CouponCode { get; set; }
        public string TransactionStatus { get { return _transactionStatus; } set { _transactionStatus = value; } }
	}

	public class CheckoutProductBase
	{
		//Orderd, ProductId, Qty, PerPrice, Totalprice
		private int _action = 0;
		private int _orderId = 0;
		private int _productId = 0;
		private int _qty = 0;
		private decimal _perprice = 0;
		private decimal _totalPrice = 0;

		public int Action { get { return _action; } set { _action = value; } }
		public int OrderId { get { return _orderId; } set { _orderId = value; } }
		public int ProductId { get { return _productId; } set { _productId = value; } }
		public int Quantity { get { return _qty; } set { _qty = value; } }
		public decimal PerPrice { get { return _perprice; } set { _perprice = value; } }
		public decimal TotalPrice { get { return _totalPrice; } set { _totalPrice = value; } }
	}
}
