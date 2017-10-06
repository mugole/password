using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HawthornPharmacy
{
    class Item
    {
        private string ItemName;
        private int Quantity;
        private string Manufacturer;
        private double PurchasePrice;
        private double SalePrice;
        private string Purpose;

        public Item()
        {
            Quantity = 0;
        }

        public string Name
        {
            set
            {
                ItemName = value;
            }
            get
            {
                return ItemName;
            }
        }

        public int _Quantity
        {
            set
            {
                Quantity = value;
            }
            get
            {
                return Quantity;
            }
        }

        public double price
        {
            set
            {
                PurchasePrice = value;
            }
            get
            {
                return PurchasePrice;
            }
        }

        public double SalesPrice
        {
            set
            {
                SalePrice = value;
            }
            get
            {
                return SalePrice;
            }
        }

        public string Maker
        {
            get
            {
                return Manufacturer;
            }
            set
            {
                Manufacturer = value;
            }
        }
        public string category
        {
            get
            {
                return Purpose;
            }
            set
            {
                Purpose = value;
            }
        }

    }
}

