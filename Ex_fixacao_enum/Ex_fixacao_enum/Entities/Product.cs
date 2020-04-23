using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_fixacao_enum.Entities
{
    class Product
    {
        public String Name { get; set; }
        public Double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
