using System;
using System.Collections.Generic;
using System.Text;

namespace ClockWorkIT_Challenge.Discounts
{
    class AppleDiscount 
    {
        public static double CalculateAppleDiscount(int numberOfApples)
        {
            if (numberOfApples > 0)
            {
                double Discounts = numberOfApples * 0.10;
                Console.WriteLine("Apples 10% Off: " + numberOfApples);
                return Discounts;
            }
            else return 0;
          
        }
        

    }

}
