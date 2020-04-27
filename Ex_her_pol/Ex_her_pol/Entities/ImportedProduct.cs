using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Ex_her_pol.Entities
{
    class ImportedProduct : Product
    {
        public Double CustomFee { get; set; }
        
        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }

        public override string PriceTag()
        {
          return  "Name: "
                +Name 
                + " Price: $" 
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) 
                + "(Customs fee: $ " 
                + CustomFee.ToString("F2",CultureInfo.InvariantCulture)
                +")";
        }


    }
}
