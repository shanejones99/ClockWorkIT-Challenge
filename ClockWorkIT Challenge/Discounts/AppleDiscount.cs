using System;
using System.Collections.Generic;
using System.Text;

namespace ClockWorkIT_Challenge.Discounts
{
    public class AppleDiscount 
    {
        public static double CalculateAppleDiscount(int numberOfApples)
        {
            if (numberOfApples > 0)
            {
                double Discounts = numberOfApples * 0.10;
                Console.WriteLine("Apples 10% Off: X{0}" + numberOfApples);
                return Discounts;
            }
                return 0;
          
        }
        

    }

}
