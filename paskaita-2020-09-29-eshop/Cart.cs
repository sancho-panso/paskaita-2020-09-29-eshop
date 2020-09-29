using System;
using System.Collections.Generic;
using System.Text;

namespace paskaita_2020_09_29_eshop
{
    class Cart
    {
        public Cart(bool tobepaidbycash)
        {
            OrderID = Guid.NewGuid();
            IsPaidByCash = tobepaidbycash;
            Products = new List<Product>();
            Services = new List<Service>();
        }
        public Guid OrderID { get; set; }
        public IList<Service> Services { get; set; }
        public IList<Product> Products { get; set; }
        public float AmmountToPay { get; set; }
        public bool IsPaidByCash { get; set; }
        public bool IsInvoiceSent { get; set; }

        public  void  AddProductToCart(Product product)
        {
            if (product.IsAdultProduct)
            {
                Console.WriteLine("What is Your Age?");
                int input = int.Parse(Console.ReadLine());
                if (product.CanIbuyAdultProducts(input))
                {
                    Products.Add(product);
                }
            }
            else
            {
                Products.Add(product);
            }
        }
    }
}
