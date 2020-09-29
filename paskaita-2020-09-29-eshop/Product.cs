
using System;
using System.Collections.Generic;
using System.Text;

namespace paskaita_2020_09_29_eshop
{
    class Product: BaseProduct, AdultProduct, KidProduct
    {
        public Supplyer Suppliers { get; set; }

        public bool IsAdultProduct { get; set; }

        public bool CanIbuyAdultProducts(int age)
        {
            return age > 18;
           
        }
    }
}
