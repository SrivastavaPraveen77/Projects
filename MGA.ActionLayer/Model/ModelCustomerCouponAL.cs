using System;

namespace MGA.ActionLayer.Model
{

    public class CustomerCoupon
        {
            public int CustomerCouponID { get; set; }

           public string CouponCode { get; set; }


             public bool? isCustom { get; set; }

           public int CustomerId { get; set; }

            public DateTime? ExpiredOn { get; set; }

             public string DiscountType { get; set; }

            public decimal? Discount { get; set; }

            public string Remarks { get; set; }
            public bool? isUsed { get; set; }
            public DateTime? UsedOn { get; set; }
            public int? UsedBy { get; set; }
            public bool? IsDeactive { get; set; }

            public double? MinPurchaseAmount { get; set; }

        }
   
}
