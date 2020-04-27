using System;
using System.Collections.Generic;
using System.Text;

namespace Galatic_conversor.Entities
{
    class Product
    {
        public String Name { get; set; }
        public int Value { get; set; }

        public Product() { }

        public Product(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}
