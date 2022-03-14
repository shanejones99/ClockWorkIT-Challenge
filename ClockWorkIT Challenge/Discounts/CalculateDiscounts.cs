using ClockWorkIT_Challenge.Discounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClockWorkIT_Challenge
{
    class CalculateDiscounts
    {
        public static double Calculate(List<BasketItem> basket)
        {
          
            int soup = FindSoupInBasket(basket);
            int bread = FindBreadInBasket(basket);
            int apples = FindApplesInBasket(basket);
            double appleDiscount =  AppleDiscount.CalculateAppleDiscount(apples);
            double soupDiscount = TinsOfSoupDiscount.CalculateTinsOfSoupDiscount(soup, bread);
            double totalDiscount = soupDiscount + appleDiscount;
                
                 return totalDiscount;
            
        }

        private static int FindApplesInBasket(List<BasketItem> basket)
        {
            int apples = 0;
            foreach (BasketItem b in basket)
            {
               if (b.ProductID == 4)
                {
                    apples++;
                }
            }
            return apples;
        }

        private static int FindBreadInBasket(List<BasketItem> basket)
        {
            int bread = 0;
            foreach (BasketItem b in basket)
            {
                if (b.ProductID == 2)
                {
                    bread++;
                }
            }
            return bread;
        }

        private static int FindSoupInBasket(List<BasketItem> basket)
        {
            int soup = 0;
            foreach (BasketItem b in basket)
            {
                if (b.ProductID == 1)
                {
                    soup++;
                }
            }
            return soup;
        }
    }
}
