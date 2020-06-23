using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MGA.Base;
using MGA.BASE.Home;
using MGADataLayer.Home;

namespace MGA.ActionLayer.Home
{
    public class HomeAL
    {
        #region Declaration
        ActionResult actionResult = new ActionResult();
        HomeDL dataLayer = new HomeDL();

		#endregion

		#region get Product by Id
		public ActionResult get_Products(ProductBase model)
        {
            actionResult = new ActionResult();
            try
            {
                actionResult.dtResult = dataLayer.get_Products(model);
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
        public ActionResult getContactUs()
        {
            actionResult = new ActionResult();
            actionResult.dtResult = dataLayer.GetContactUs();
            if (actionResult.dtResult != null && actionResult.dtResult.Rows.Count > 0)
            {
                actionResult.IsSuccess = true;
            }
            return actionResult;
        }
        #endregion



		#region get User adress details
		public ActionResult get_UserAddress(CheckoutBase model)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dtResult = dataLayer.get_UserAddress(model);
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

        #region get DeliveryDetail by Pincode
        public ActionResult get_PrductavailabilityBypincode(string Pincode)
        {
            actionResult = new ActionResult();
            try
            {
                actionResult.dtResult = dataLayer.get_PrductavailabilityBypincode(Pincode);
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





		#region SaveOrder
		public ActionResult SaveOrder(CheckoutBase checkoutBase)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dsResult = dataLayer.SaveOrder(checkoutBase);
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

		#region SaveOrder
		public ActionResult SaveOrderDetail(CheckoutProductBase checkoutProductBase)
		{
			actionResult = new ActionResult();
			try
			{
				actionResult.dsResult = dataLayer.SaveOrderDetail(checkoutProductBase);
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

	}
}
