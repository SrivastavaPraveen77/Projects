using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MGAChargerEcommerce.Models
{
    public class MailModel
    {
        public string Name
        {
            get;
            set;
        }
        public string Mobile
        {
            get;
            set;
        }

        public string From
        {
            get;
            set;
        }
        public string To
        {
            get;
            set;
        }
        public string Subject
        {
            get;
            set;
        }
        public string Body
        {
            get;
            set;
        }

        public int ID { get; set; }

        public string CustomerCareNumber { get; set; }

        public string SalesSupportNumber { get; set; }

        public string CustomerCareEmailAddress { get; set; }
        public string Address { get; set; }
        public string AboutUs { get; set; }
    }
}