using System;
using System.Collections.Generic;
using System.Text;

namespace ClockWorkIT_Challenge
{
   public class CreateProducts
    {

        public static List<Product> Create()
        { 
            //Creates products and store them in a list.
            List<Product> products = new List<Product>();
            products.Add(new Product(1,"Soup",0.65));
            products.Add(new Product(2, "Bread", 0.80));
            products.Add(new Product(3, "Milk", 1.30));
            products.Add(new Product(4, "Apples", 1.00));
            return products;
        }

       
         
    }
}
