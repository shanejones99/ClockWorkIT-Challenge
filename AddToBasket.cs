using System;
using System.Collections.Generic;

public class Class1
{
	public AddToBasket()
	{

        Console.WriteLine("Type in the products you wish to add to your basket:");
        string userInput = Console.ReadLine();
        double totalPrice = 0;

        List<Product> products = CreateProducts.Create();


        string[] productsInCart = userInput.Split(" ");

        try
        {
            foreach (String str in productsInCart)
        {
            foreach (Product p in products)


                if (str.ToLower() == p.ProductName.ToLower())
                {

                    basket.Add(new BasketItem(p.ProductID, p.ProductPrice));

                }
            else
                {
                    throw new Exception ("ERROR :Product: " + str + " Does not exist. ")
                }
            catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        }
        }
        
    }
}
