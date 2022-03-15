using System;
using System.Collections.Generic;
using System.Text;

namespace ClockWorkIT_Challenge
{
    public class BasketItem
    {
        public int ProductID { get; set; }
        public double Price { get; set; }
        public string ProductName { get; set; }
        public BasketItem (int productID, double price, string productName)
        {
            ProductID = productID;
            Price = price;
            ProductName = productName;
           
        }
    }
}
