using System;
using System.Collections.Generic;
using System.Text;

namespace ClockWorkIT_Challenge.Discounts
{
    class TinsOfSoupDiscount
    {
        public static double CalculateTinsOfSoupDiscount(int soup, int bread)
        {
            int breadEligibleForDiscount = 0;
            double discount = 0;
            //calculate the amount of bread that is eligible for discount
            if (soup >= 2 && soup %2 == 0)  breadEligibleForDiscount = soup / 2;
            else if (soup >= 2) breadEligibleForDiscount = soup - 1 / 2;

            //apply the discount to the correct number of bread
            if (breadEligibleForDiscount > 0 && breadEligibleForDiscount >= bread) discount = bread * 0.4; 
            
     else if (breadEligibleForDiscount > 0)
           {
                while (breadEligibleForDiscount < bread)
                {
                    bread--;
                    

               }
                discount = bread * 0.4;
            }
            else return 0;
 
                 Console.WriteLine("Two tins of soup & half price bread offer: -£{0}", Math.Round(discount,2));
                return discount;
            
           
        }
    }
}
