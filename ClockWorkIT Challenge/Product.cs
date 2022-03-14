using System;
using System.Collections.Generic;
using System.Text;

namespace ClockWorkIT_Challenge
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public string ProductCategory { get; set; }

        public  Product(int productID, string productName, double productPrice)
        {
            ProductID = productID;
            ProductName = productName;
            ProductPrice = productPrice;
          

        }
    }
}
