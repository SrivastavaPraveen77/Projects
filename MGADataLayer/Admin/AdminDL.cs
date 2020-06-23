using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MGA.Base.Admin;

namespace MGA.DataLayer.Admin
{
	public class AdminDL
	{
		#region Declaration
		DataSet dsContainer;
		DataTable dtContainer;
		#endregion
		#region get pages
		public DataTable GetPage(ManagePages model)
		{
			dtContainer = new DataTable();

			try
			{
				MyParameter[] myParams ={
										 new MyParameter("@Id",model.PageId)
										};
				Common.Set_Procedures("sp_getPages");
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
		#region Update Pages
		public DataTable UpdatePage(ManagePages model)
		{
			dtContainer = new DataTable();

			try
			{
				MyParameter[] myParams ={
										 new MyParameter("@Id",model.PageId),
										 new MyParameter("@Content",model.HtmlContent)
										};
				Common.Set_Procedures("sp_updatePages");
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
		#region Get Event
		public DataTable Get_Event()
		{
			dtContainer = new DataTable();
			try
			{
				MyParameter[] myParams ={

										};
				Common.Set_Procedures("sp_getEvent");
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

		#region Add Event
		public DataTable add_Event(PhotoGalleryBase model)
		{
			dtContainer = new DataTable();
			try
			{
				MyParameter[] myParams ={
										   new MyParameter("@EventName", model.EventName),
										   new MyParameter("@EventDescription", model.EventDescription),
											new MyParameter("@EventImage",model.EventImage),
										   new MyParameter("@CreatedBy", model.CreatedBy),

										};
				Common.Set_Procedures("sp_AddEvent");
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

		#region Method DeletePhotoGallery
		public DataTable DeleteEvent(PhotoGalleryBase photogalleryBase)
		{
			dtContainer = new DataTable();
			dsContainer = new DataSet();
			try
			{
				MyParameter[] myParams ={


											new MyParameter("@id",photogalleryBase.ID)


										};

                Common.Set_Procedures("Delete_Event");
                //Common.Set_Procedures("Delete_PhotoGallery");
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

        #region Method DeletePhotoGallery
        public DataTable DeletePhotoGallery(PhotoGalleryBase photogalleryBase)
        {
            dtContainer = new DataTable();
            dsContainer = new DataSet();
            try
            {
                MyParameter[] myParams ={


											new MyParameter("@id",photogalleryBase.ID)


										};

                Common.Set_Procedures("Delete_PhotoGallery");
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


		#region Get Event
		public DataTable Get_PrestigiousCustomer()
		{
			dtContainer = new DataTable();
			try
			{
				MyParameter[] myParams ={

										};
                Common.Set_Procedures("sp_getEvents");
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

        #region Get OurClients
        public DataTable Get_OurClients()
        {
            dtContainer = new DataTable();
            try
            {
                MyParameter[] myParams ={

										};
                Common.Set_Procedures("sp_getOurClients");
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



		#region AddPrestigiousCustomer
		public DataTable add_PrestigiousCustomer(PrestigiousCustomerBase model)
		{
			dtContainer = new DataTable();
			try
			{
				MyParameter[] myParams ={
										   new MyParameter("@EventName", model.EventName),
                                           new MyParameter("@EventUrl", model.EventUrl),
											new MyParameter("@Image",model.Image),
										   new MyParameter("@CreatedBy", model.CreatedBy),

										};
                //Common.Set_Procedures("sp_AddPrestigiousCustomer");
                Common.Set_Procedures("sp_AddEventGallery");
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

		#region Method DeletePrestigiousCustomer
		public DataTable DeletePrestigiousCustomer(PrestigiousCustomerBase prestigiousCustomerBase)
		{
			dtContainer = new DataTable();
			dsContainer = new DataSet();
			try
			{
				MyParameter[] myParams ={


											new MyParameter("@id",prestigiousCustomerBase.ID)


										};
				Common.Set_Procedures("Delete_prestigiousCustomer");
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



        #region Method DeleteOurClient
        public DataTable DeleteOurClient(int Id)
        {
            dtContainer = new DataTable();
            dsContainer = new DataSet();
            try
            {
                MyParameter[] myParams ={


											new MyParameter("@id",Id)


										};
                Common.Set_Procedures("[Delete_OurClient]");
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



		#region get ContactUs
		public DataTable GetContactUs(ContactUsBase model)
		{
			dtContainer = new DataTable();

			try
			{
				MyParameter[] myParams ={
										 new MyParameter("@Id",model.ID)
										};
				Common.Set_Procedures("sp_getContactUs");
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
		#region ContactUs
		public DataTable ContactUs(ContactUsBase model)
		{
			dtContainer = new DataTable();

			try
			{
				MyParameter[] myParams ={
										 new MyParameter("@Id",model.ID),
										 new MyParameter("@CustomerCareNumber",model.CustomerCareNumber),
										 new MyParameter("@CustomerSalesSupportNumber",model.CustomerSalesSupportNumber),
										 new MyParameter("@EmailAddress",model.EmailAddress),
										 new MyParameter("@CustomerAddress",model.Address),
										 new MyParameter("@AboutUs",model.AboutUs),
										 new MyParameter("@CreatedBy",model.CreatedBy)

										};
				Common.Set_Procedures("sp_updateContactUs");
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

        #region Add Product
        public DataTable addProduct(AddProductBase model)
        {
            dtContainer = new DataTable();

            try
            {
                MyParameter[] myParams ={
										 new MyParameter("@ProductId",model.ProductId),
										  new MyParameter("@ProductCode",model.ProductCode),
										 new MyParameter("@ProductName",model.ProductName),
										 new MyParameter("@ProductCategory",model.ProductCategory),
                                         new MyParameter("@ProductOrder",model.ProductOrder),
										 new MyParameter("@ProductDescription",model.ProductDescription),
										 new MyParameter("@ProductReturnPolicy",model.ProductReturnPolicy),
										 new MyParameter("@ProductRate",model.ProductRate),
										 new MyParameter("@OfferDescription",model.OfferDescription),
										 new MyParameter("@SubTotalAmount",model.SubTotalAmount),
										 new MyParameter("@CGSTPercentage",model.CGSTPercentage),
										 new MyParameter("@CGSTAmount",model.CGSTAmount),
										 new MyParameter("@SGSTPercentage",model.SGSTPercentage),
										 new MyParameter("@SGSTAmount",model.SGSTAmount),
										 new MyParameter("@IGSTPercentage",model.IGSTPercentage),
										 new MyParameter("@IGSTAmount",model.IGSTAmount),
										 new MyParameter("@TotalAmountIncludeTax",model.TotalAmountIncludeTax),
										 new MyParameter("@ProductImage",model.ProductImage),
                                         new MyParameter("@ProductImageSideView",model.ProductImageSideView),
                                         new MyParameter("@ProductImageTopView",model.ProductImageTopView),
                                         new MyParameter("@ProductImageBottom",model.ProductImageBottom),
                                         new MyParameter("@ProductImageDetail",model.ProductImageDetail),

										 new MyParameter("@CreatedBy",model.CreatedBy),
										 new MyParameter("@UpdatedBy",model.UpdatedBy)

										};
                Common.Set_Procedures("sp_AddProduct");
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

		#region get category
		public DataTable get_ProductCategories()
		{
			dtContainer = new DataTable();
			try
			{
				MyParameter[] myParams ={

										};
				Common.Set_Procedures("sp_getProductCategory");
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

		#region Method DeleteProduct
		public DataTable DeleteProduct(AddProductBase productBase)
		{
			dtContainer = new DataTable();
			dsContainer = new DataSet();
			try
			{
				MyParameter[] myParams ={


											new MyParameter("@id",productBase.ProductId)


										};
				Common.Set_Procedures("Delete_Product");
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

		#region get Product
		public DataTable get_Product()
		{
			dtContainer = new DataTable();
			try
			{
				MyParameter[] myParams ={

										};
				Common.Set_Procedures("sp_getProduct");
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

		#region get Product
		public DataTable get_Product(AddProductBase model)
		{
			dtContainer = new DataTable();
			try
			{
				MyParameter[] myParams ={
										 new MyParameter("@ProductId",model.ProductId)
										};
				Common.Set_Procedures("sp_getProductByID");
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

		#region get category
		public DataTable get_CourierCategory()
		{
			dtContainer = new DataTable();
			try
			{
				MyParameter[] myParams ={

										};
				Common.Set_Procedures("sp_getCorierCategory");
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

		#region get State
		public DataTable get_State()
		{
			dtContainer = new DataTable();
			try
			{
				MyParameter[] myParams ={

										};
				Common.Set_Procedures("sp_getState");
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

		#region get City
		public DataTable get_City(int stateId)
		{
			dtContainer = new DataTable();
			try
			{
				MyParameter[] myParams ={
			new MyParameter("@StateId",stateId)
										};
				Common.Set_Procedures("sp_getCity");
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


		#region ContactUs
		public DataTable AddUpdateShippingDetail(ShippingDetailBase model)
		{
			dtContainer = new DataTable();

			try
			{
				MyParameter[] myParams ={
										 new MyParameter("@Action",model.Action),
										 new MyParameter("@Id",model.ShippingID),
										 new MyParameter("@Source",model.SourceName),
										 new MyParameter("@StateName",model.StateName),
										 new MyParameter("@CourierName",model.CourierName),
										 new MyParameter("@ProductName",model.ProductName),
										 new MyParameter("@CourierCategory",model.CourierCategory),
										 new MyParameter("@CourierCharges",model.CourierCharge),
										 new MyParameter("@productDimension",model.ProductDimension),
										 new MyParameter("@productWeight",model.ProdctWeight),
										 new MyParameter("@CreatedBy",model.CreatedBy),
										 new MyParameter("@UpdatedBy",model.UpdatedBy)

										};
				Common.Set_Procedures("sp_AddUpdateShipingDetails");
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

		#region get Product
		public DataTable getShipingDetails(ShippingDetailBase model)
		{
			dtContainer = new DataTable();
			try
			{
				MyParameter[] myParams ={

										 new MyParameter("@ShipingId",model.ShippingID)
										};
				Common.Set_Procedures("sp_getShipingDetails");
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

		public DataTable get_EnquieryDetail()
		{
			dtContainer = new DataTable();
			try
			{
				MyParameter[] myParams ={

										};
				Common.Set_Procedures("sp_GetenquireyDetails");
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

		#region get ComplaintDetail
		public DataTable GetComplaintDetail(ComplaintDetailBase model)
		{
			dtContainer = new DataTable();

			try
			{
				MyParameter[] myParams ={
										 new MyParameter("@Id",model.Id)
										};
				Common.Set_Procedures("sp_getComplaintDetail");
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

		#region update Complaint Detail
		public DataTable AddUpdateComplaintDetail(ComplaintDetailBase model)
		{
			dtContainer = new DataTable();

			try
			{
				MyParameter[] myParams ={
										 new MyParameter("@Action",model.Action),
										 new MyParameter("@Id",model.Id),
										 new MyParameter("@CustomerName",model.CustomerName),
										 new MyParameter("@CustomerContact",model.CustomerContact),
										 new MyParameter("@CustomerEmail",model.CustomerEmail),
										 new MyParameter("@DealerName",model.DealerName),
										 new MyParameter("@InvoiceNo",model.InvoiceNo),
										 new MyParameter("@PurchaseDate",model.PurchaseDate),
										 new MyParameter("@productSerial",model.ProductSerial),
										 new MyParameter("@ModalNo",model.ModalNo),
										  new MyParameter("@Complaint",model.Complaint),
										  new MyParameter("@Status",model.UpdateStatus),
										   new MyParameter("@Remark",model.Addremark),
										 new MyParameter("@CreatedBy",model.CreatedBy),
										 new MyParameter("@UpdatedBy",model.ModifyBy)

										};
				Common.Set_Procedures("sp_AddUpdateComplaintDetails");
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

		public DataTable get_myOrderDetail(int OrderId)
		{
			dtContainer = new DataTable();
			try
			{
				MyParameter[] myParams ={
										new MyParameter("@OrderId",OrderId)
										};
				Common.Set_Procedures("sp_getMyOrderDetail");
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


        #region update Password
        public DataTable UpdateuserPassword(string EmailId, string Password)
        {
            dtContainer = new DataTable();

            try
            {
                MyParameter[] myParams ={
										 new MyParameter("@EmailId",EmailId),
										 new MyParameter("@Password",Password)
							

										};
                Common.Set_Procedures("sp_updatePassword");
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
        public DataTable GetSugesterCustomerList(string prefix)
        {
            dtContainer = new DataTable();

            try
            {
                MyParameter[] myParams ={
                                         new MyParameter("@prefix",prefix),
                                        
                                        };
                Common.Set_Procedures("USP_SugesterCoustomer");
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
        public DataTable GetSugesterCustomerList(string couponCode, int custid)
        {
            dtContainer = new DataTable();

            try
            {
                MyParameter[] myParams ={
                                         new MyParameter("@customerId",custid),
                                         new MyParameter("@CouponCode",couponCode),

                                        };
                Common.Set_Procedures("USP_GetCouponDetails");
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
        
        public DataTable getCouponList(int? couponID)
        {
            dtContainer = new DataTable();

            try
            {
                MyParameter[] myParams ={
                                         new MyParameter("@QueryType",(couponID==null?"SelectAll":"SelectbyId")),
                                         new MyParameter("@CustomerCouponID",couponID),

                                        };
                Common.Set_Procedures("USP_CustomerCoupon");
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
        public DataTable AddCustomerCoupons(int? CustomerCouponID,string CouponCode,bool? isCustom ,int CustomerId,
            DateTime? ExpiredOn ,string DiscountType,decimal? Discount , string Remarks, double? MinPurchaseAmount)
        {
            dtContainer = new DataTable();
            try
            {
                MyParameter[] myParams ={
                                         new MyParameter("@QueryType","Save"),
                                         new MyParameter("@CustomerCouponID",CustomerCouponID),
                                         new MyParameter("@CouponCode",CouponCode),
                                         new MyParameter("@isCustom",isCustom),
                                         new MyParameter("@CustomerId",CustomerId),
                                         new MyParameter("@ExpiredOn",ExpiredOn),
                                         new MyParameter("@DiscountType",DiscountType),
                                         new MyParameter("@Discount",Discount),
                                         new MyParameter("@Remarks",Remarks),
                                         new MyParameter("@MinPurchaseAmount",MinPurchaseAmount)
                                        };
                Common.Set_Procedures("USP_CustomerCoupon");
                Common.Set_ParameterLength(10);
                Common.Set_Parameters(myParams);
                dtContainer = Common.Execute_Procedures_LoadData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtContainer;


        }
        #region CouponCode



        #endregion
    }
}
