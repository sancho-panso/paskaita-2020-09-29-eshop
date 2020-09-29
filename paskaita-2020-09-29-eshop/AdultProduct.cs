using System;
using System.Collections.Generic;
using System.Text;

namespace paskaita_2020_09_29_eshop
{
    interface AdultProduct
    {
        bool IsAdultProduct { get; set; }

        bool CanIbuyAdultProducts(int age);
    }
}
