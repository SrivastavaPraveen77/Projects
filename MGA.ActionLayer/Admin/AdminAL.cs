using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MGA.Base.Admin;
using MGA.DataLayer.Admin;
using MGA.Base;
using MGA.ActionLayer.Model;

namespace MGA.ActionLayer.Admin
{
    public class AdminAL
    {
		#region Declaration
		MGA.DataLayer.Admin.AdminDL dataLayer = new MGA.DataLayer.Admin.AdminDL();
		MGA.Base.ActionResult actionResult;
		#endregion

		#region Get Page

		public ActionResult GetPage(ManagePages model)
		{
			actionResult = new ActionResult();
			try
			{

				actionResult.dtResult = dataLayer.GetPage(model);
				if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
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


		#region Update Pages
		public ActionResult UpdatePage(ManagePages model)
		{
			actionResult = new ActionResult();
			try
			{

				actionResult.dtResult = dataLayer.UpdatePage(model);
				if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
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


		#region Get Event
		public ActionResult getEvent()
		{
			actionResult = new ActionResult();
			actionResult.dtResult = dataLayer.Get_Event();
			if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
			{
				actionResult.IsSuccess = true;
			}
			return actionResult;
		}
		#endregion

		#region Add Event
		public bool addEvent(PhotoGalleryBase model)
		{
			actionResult = new Base.ActionResult();
			bool check = false;
			actionResult.dtResult = dataLayer.add_Event(model);
			if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0 && actionResult.dtResult.Rows[0][0].ToString() == "1")
			{
				actionResult.IsSuccess = true;
				check = true;
			}
			return check;
		}
		#endregion

		#region Method DeleteEvent
		public ActionResult DeleteEvent(PhotoGalleryBase photogalleryBase)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dtResult = dataLayer.DeleteEvent(photogalleryBase);
				if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
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

        #region Method DeletePhotoGallery
        public ActionResult DeletePhotoGallery(PhotoGalleryBase photogalleryBase)
        {
            actionResult = new ActionResult();
            try
            {
                actionResult.dtResult = dataLayer.DeletePhotoGallery(photogalleryBase);
                if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
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

		#region Get Event
		public ActionResult getPrestigiousCustomer()
		{
			actionResult = new ActionResult();
			actionResult.dtResult = dataLayer.Get_PrestigiousCustomer();
			if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
			{
				actionResult.IsSuccess = true;
			}
			return actionResult;
		}
		#endregion

        #region Get Event
        public ActionResult Get_OurClients()
        {
            actionResult = new ActionResult();
            actionResult.dtResult = dataLayer.Get_OurClients();
            if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
            {
                actionResult.IsSuccess = true;
            }
            return actionResult;
        }
        #endregion



		#region  AddPrestigiousCustomer
		public bool addPrestigiousCustomer(PrestigiousCustomerBase model)
		{
			actionResult = new Base.ActionResult();
			bool check = false;
			actionResult.dtResult = dataLayer.add_PrestigiousCustomer(model);
			if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0 && actionResult.dtResult.Rows[0][0].ToString() == "1")
			{
				actionResult.IsSuccess = true;
				check = true;
			}
			return check;
		}
		#endregion

		#region Method DeletePrestigiousCustomer
		public ActionResult DeletePrestigiousCustomer(PrestigiousCustomerBase prestigiousCustomerBase)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dtResult = dataLayer.DeletePrestigiousCustomer(prestigiousCustomerBase);
				if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
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

        #region Method DeleteOurClient
        public ActionResult DeleteOurClient(int Id)
		{
			actionResult = new ActionResult();
			try
			{
                actionResult.dtResult = dataLayer.DeleteOurClient(Id);
				if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
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


		#region UpdateContactUs]
		public ActionResult UpdateContactUs(ContactUsBase model)
		{
			actionResult = new ActionResult();
			try
			{

				actionResult.dtResult = dataLayer.ContactUs(model);
				if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
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

		#region Get ContactUs
		public ActionResult getContactUs(ContactUsBase model)
		{
			actionResult = new ActionResult();
			actionResult.dtResult = dataLayer.GetContactUs(model);
			if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
			{
				actionResult.IsSuccess = true;
			}
			return actionResult;
		}
		#endregion

		#region Get Category
		public ActionResult getProductCategory()
		{
			actionResult = new ActionResult();
			actionResult.dtResult = dataLayer.get_ProductCategories();
			if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
			{
				actionResult.IsSuccess = true;
			}
			return actionResult;
		}
		#endregion

		#region Add Product
		public bool addProduct(AddProductBase model)
		{
			actionResult = new Base.ActionResult();
			bool check = false;
			actionResult.dtResult = dataLayer.addProduct(model);
			if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0 && actionResult.dtResult.Rows[0][0].ToString() == "1")
			{
				actionResult.IsSuccess = true;
				check = true;
			}
			return check;
		}
		#endregion

		#region Method DeleteProduct
		public ActionResult DeleteProduct(AddProductBase productBase)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dtResult = dataLayer.DeleteProduct(productBase);
				if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
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

		#region Get Product
		public ActionResult getProduct()
		{
			actionResult = new ActionResult();
			actionResult.dtResult = dataLayer.get_Product();
			if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
			{
				actionResult.IsSuccess = true;
			}
			return actionResult;
		}
		#endregion

		#region Get ProductByID
		public ActionResult getProductById(AddProductBase model)
		{
			actionResult = new ActionResult();
			actionResult.dtResult = dataLayer.get_Product(model);
			if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
			{
				actionResult.IsSuccess = true;
			}
			return actionResult;
		}
		#endregion

		#region Get Courier Category
		public ActionResult getCourierCategory()
		{
			actionResult = new ActionResult();
			actionResult.dtResult = dataLayer.get_CourierCategory();
			if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
			{
				actionResult.IsSuccess = true;
			}
			return actionResult;
		}
		#endregion

		#region Get State
		public ActionResult getState()
		{
			actionResult = new ActionResult();
			actionResult.dtResult = dataLayer.get_State();
			if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
			{
				actionResult.IsSuccess = true;
			}
			return actionResult;
		}
		#endregion

		#region Add Product
		public bool AddUpdateShippingDetail(ShippingDetailBase model)
		{
			actionResult = new Base.ActionResult();
			bool check = false;
			actionResult.dtResult = dataLayer.AddUpdateShippingDetail(model);
			if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0 && actionResult.dtResult.Rows[0][0].ToString() == "1")
			{
				actionResult.IsSuccess = true;
				check = true;
			}
			return check;
		}
		#endregion

		#region Get ShipingDetails
		public ActionResult getShipingDetails(ShippingDetailBase model)
		{
			actionResult = new ActionResult();
			actionResult.dtResult = dataLayer.getShipingDetails(model);
			if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
			{
				actionResult.IsSuccess = true;
			}
			return actionResult;
		}
		#endregion

		#region Get EnquiryDetails
		public ActionResult getEnquieryDetail()
		{
			actionResult = new ActionResult();
			actionResult.dtResult = dataLayer.get_EnquieryDetail();
			if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
			{
				actionResult.IsSuccess = true;
			}
			return actionResult;
		}
		#endregion


		#region Get ComplaintsDetails
		public ActionResult getComplaintDetail(ComplaintDetailBase model)
		{
			actionResult = new ActionResult();
			actionResult.dtResult = dataLayer.GetComplaintDetail(model);
			if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
			{
				actionResult.IsSuccess = true;
			}
			return actionResult;
		}
		#endregion

		#region Add update ComplaintsDetail
		public bool AddUpdateComplaintDetail(ComplaintDetailBase model)
		{
			actionResult = new Base.ActionResult();
			bool check = false;
			actionResult.dtResult = dataLayer.AddUpdateComplaintDetail(model);
			if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0 && actionResult.dtResult.Rows[0][0].ToString() == "1")
			{
				actionResult.IsSuccess = true;
				check = true;
			}
			return check;
		}
		#endregion

		#region Get MyOrderDetails
		public ActionResult getmyOrderDetail(int OrderId = 0)
		{
			actionResult = new ActionResult();
			actionResult.dtResult = dataLayer.get_myOrderDetail(OrderId);
			if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
			{
				actionResult.IsSuccess = true;
			}
			return actionResult;
		}
		#endregion

		#region Get City byStateID
		public ActionResult getCity(int stateId)
		{
			actionResult = new ActionResult();
			actionResult.dtResult = dataLayer.get_City(stateId);
			if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
			{
				actionResult.IsSuccess = true;
			}
			return actionResult;
		}
		#endregion


        #region Add update ComplaintsDetail
        public bool UpdateuserPassword(string EmailId,string Password)
        {
            actionResult = new Base.ActionResult();
            bool check = false;
            actionResult.dtResult = dataLayer.UpdateuserPassword(EmailId, Password);
            if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0 && actionResult.dtResult.Rows[0][0].ToString() == "1")
            {
                actionResult.IsSuccess = true;
                check = true;
            }
            return check;
        }
        #endregion
        #region CouponCode
        public ActionResult getCustomerList(string prefix)
        {
            actionResult = new ActionResult();
            actionResult.dtResult = dataLayer.GetSugesterCustomerList(prefix);
            if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
            {
                actionResult.IsSuccess = true;
            }
            return actionResult;
        }
        public ActionResult getCouponDetails(string couponCode, int custid)
        {
            actionResult = new ActionResult();
            actionResult.dtResult = dataLayer.GetSugesterCustomerList(couponCode,  custid);
            if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
            {
                actionResult.IsSuccess = true;
            }
            return actionResult;
        }

        public ActionResult SaveCustomerCoupons(CustomerCoupon model)
        {
            actionResult = new ActionResult();
            actionResult.dtResult = dataLayer.AddCustomerCoupons(model.CustomerCouponID, model.CouponCode, model.isCustom ,
                model.CustomerId, model.ExpiredOn , model.DiscountType, model.Discount, model.Remarks, model.MinPurchaseAmount);
            if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
            {
                actionResult.IsSuccess = true;
            }
            return actionResult;
        }

        public ActionResult getCouponList(int? couponID)
        {
            actionResult = new ActionResult();
            actionResult.dtResult = dataLayer.getCouponList(couponID);
            if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
            {
                actionResult.IsSuccess = true;
            }
            return actionResult;
        }

        #endregion

    }
}
