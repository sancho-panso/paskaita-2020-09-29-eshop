using System;

namespace paskaita_2020_09_29_eshop
{
    class Program
    {
        static void Main(string[] args)
        {
            AdultProduct adultDVD = new Product() { Name = "kazanova", Price = 19.99M };
            adultDVD.IsAdultProduct = true;
            Console.WriteLine("Print Y if payment by card");
            bool isByCash = Console.ReadLine() == "Y";
            Cart krepselis = new Cart(isByCash);

            krepselis.AddProductToCart(new Product() { Name = "sampunas", Price = 9.99M });
            krepselis.AddProductToCart(adultDVD as Product);
            decimal sum = 0;
            foreach (var item in krepselis.Products)
            {
                Console.WriteLine(item.Name);
                sum = sum + item.Price;
            }
            Console.WriteLine("Total amount to pay: " + sum);
        }
    }
}
