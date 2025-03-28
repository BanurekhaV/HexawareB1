using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_CSharp
{
    public class Products
    {
        private int productNumber;
        public string ProductName;
        protected float Price;
        internal int Qty;

        void AssignProductDetails()
        {
            productNumber = 10;
            ProductName = "Laptops";
            Price = 58000;
            Qty = 100;
        }

    }

    class Checkprotection
    {
        public void SeeAvailability()
        {
            Products products = new Products();
            products.ProductName = "Desktops";
            products.Qty = 5;
        }
    }

    class derivedClass : Products
    {
        public void SeeAvailability()
        {
            Products prd = new Products();
            prd.ProductName = "Mobiles";
            prd.Qty = 50;

            derivedClass dc = new derivedClass();
            dc.ProductName = "Smart Watches";
            dc.Qty = 10;
            dc.Price = 8000;
        }
    }

}