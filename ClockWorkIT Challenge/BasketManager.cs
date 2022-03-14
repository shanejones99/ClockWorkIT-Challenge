using System;
using System.Collections.Generic;
namespace ClockWorkIT_Challenge {
    public class BasketManager
    {
        public static void AddProductsToBasket()
        {

            Console.WriteLine("Type in the products you wish to add to your basket:");
            string userInput = Console.ReadLine();

            List<BasketItem> basket = new List<BasketItem>();
            List<Product> products = CreateProducts.Create();


            string[] productsInCart = userInput.Split(" ");

                foreach (String str in productsInCart)
                {           
                    foreach (Product p in products) if (str.ToLower() == p.ProductName.ToLower())basket.Add(new BasketItem(p.ProductID, p.ProductPrice, p.ProductName));   
                }
            
        
            CalculateCost(basket);

        }

        private static void CalculateCost(List<BasketItem> basket)
        {
            double basketPrice = 0;
           foreach (BasketItem b in basket) basketPrice += b.Price;
            Console.WriteLine("Subtotal: £{0}", basketPrice);
            double discount = CalculateDiscounts.Calculate(basket);
            double finalTotal = basketPrice - discount;
            if (discount == 0) { Console.WriteLine("(No Offers available)"); }
            Console.WriteLine("Final Total: £{0}" ,Math.Round(finalTotal,2));

           
        }
    }

        
}
        
   

