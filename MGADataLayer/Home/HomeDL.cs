using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MGA.BASE.Home;

namespace MGADataLayer.Home
{
	public class HomeDL
	{
		#region Declaration
		DataSet dsContainer;
		DataTable dtContainer;
		#endregion

		#region get product by id
		public DataTable get_Products(ProductBase model)
		{
			dtContainer = new DataTable();
			try
			{
				MyParameter[] myParams =
					{
					 new MyParameter("@ProductId",model.ProductId),
					 new MyParameter("@ProductCategory",model.ProductCategory),
					 new MyParameter("@Action",model.ActionId)
					};
				Common.Set_Procedures("WEB_getProductRecords");
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

		#region get product by id
		public DataTable get_UserAddress(CheckoutBase model)
		{
			dtContainer = new DataTable();
			try
			{
				MyParameter[] myParams =
					{
					 new MyParameter("@UserId",model.UserId),
					 new MyParameter("@DPinCode",model.DPinCode),
					 new MyParameter("@Action",model.Action)
					};
				Common.Set_Procedures("WEB_getUserRecords");
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


        #region get product Deleviery Time by Pincode
        public DataTable get_PrductavailabilityBypincode(string  Pincode)
        {
            dtContainer = new DataTable();
            try
            {
                MyParameter[] myParams =
					{
					 new MyParameter("@Pincode",Pincode)
					};
                Common.Set_Procedures("sp_getDetailByID");
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
        public DataTable GetContactUs()
        {
            dtContainer = new DataTable();

            try
            {
                MyParameter[] myParams ={
										 new MyParameter("@Id",'1')
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


		public DataSet SaveOrder(CheckoutBase checkoutBase)
		{
			dsContainer = new DataSet();
			try
			{
				MyParameter[] myParams ={
										  new MyParameter("@Action",checkoutBase.Action),
										  new MyParameter("@OrderId",checkoutBase.OrderId),
										  new MyParameter("@TxId",checkoutBase.TxId),
										  new MyParameter("@UserId",checkoutBase.UserId),
										  new MyParameter("@TotalOrderAmount",checkoutBase.TotalOrderAmount),
										  new MyParameter("@DiscountAmount",checkoutBase.DiscountAmount),
										  new MyParameter("@CODCharges",checkoutBase.CODCharges),
										  new MyParameter("@GrandTotalAmount",checkoutBase.GrandTotalAmount),
										  new MyParameter("@PaymentMode",checkoutBase.PaymentMode),
										  new MyParameter("@VAT",checkoutBase.VAT),
										  new MyParameter("@ServiceTax",checkoutBase.ServiceTax),
										  new MyParameter("@AWBNumber",checkoutBase.AWBNumber),
											new MyParameter("@BName",checkoutBase.BName),
										  new MyParameter("@BEmail",checkoutBase.BEmail),
										  new MyParameter("@BPhoneNo",checkoutBase.BPhoneNo),
											new MyParameter("@BState",checkoutBase.BState),
											new MyParameter("@BCity",checkoutBase.BCity),
											new MyParameter("@BAddress",checkoutBase.BAddress),
											new MyParameter("@BPincode",checkoutBase.BPinCode),
												new MyParameter("@DName",checkoutBase.DName),
										  new MyParameter("@DEmail",checkoutBase.DEmail),
										  new MyParameter("@DPhoneNo",checkoutBase.DPhoneNo),
											new MyParameter("@DState",checkoutBase.DState),
											new MyParameter("@DCity",checkoutBase.DCity),
											new MyParameter("@DAddress",checkoutBase.DAddress),
											new MyParameter("@DPincode",checkoutBase.BPinCode),
											new MyParameter("@TransactionStatus",checkoutBase.TransactionStatus),
                                            new MyParameter("@CouponCode",checkoutBase.CouponCode)
                                        };
				Common.Set_Procedures("sp_SaveOrderHeader");
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

		public DataSet SaveOrderDetail(CheckoutProductBase checkoutProductBase)
		{
			dsContainer = new DataSet();
			try
			{
				MyParameter[] myParams ={
										  new MyParameter("@Action",checkoutProductBase.Action),
										  new MyParameter("@OrderId",checkoutProductBase.OrderId),
										  new MyParameter("@ProductId",checkoutProductBase.ProductId),
										  new MyParameter("@Quantity",checkoutProductBase.Quantity),
										  new MyParameter("@PerPrice",checkoutProductBase.PerPrice),
										  new MyParameter("@TotalPrice",checkoutProductBase.TotalPrice)
										};
				Common.Set_Procedures("sp_SaveOrderDetail");
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

	}
}
