using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using HealthPharmacy;

namespace HealthPharmacy
{
    class Sales
    {
        //It will start the clock for Monthly report generation
        private Stopwatch StartTime_Month;
        private Stopwatch EndTime_Month;
        private Stopwatch EntTime_Week;
        //It will start the clock for Monthly report generation
        private Stopwatch StartTime_Week;
        //Sales needs to know about Items, to generate analysis reports
        private string Name;
        private string category;
        private int Quantity;
        private double PurchasePrice;
        private double SalesPrice;

        public Sales()
        {
            Quantity = 0;
        }

       public string ItemName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
      public string ItemCategory
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

      public  int ItemQuantity
        {
            get
            {
                return Quantity;
            }
            set
            {
                Quantity = value;
            }
        }

       public double ItemPurchasePrice
        {
            get
            {
                return PurchasePrice;
            }
            set
            {
                PurchasePrice = value;
            }
        }

        public double ItemSalesPrice
        {
            get
            {
                return SalesPrice;
            }
            set
            {
               SalesPrice = value;
            }
        }
    }
}
