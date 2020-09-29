using System;
using System.Collections.Generic;
using System.Text;

namespace paskaita_2020_09_29_eshop
{
    public abstract class BaseProduct
    {
        public Guid id { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public Status Status { get; set; }

        public string Name { get; set; }

    }
}
