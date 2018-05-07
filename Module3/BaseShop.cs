using System;
using System.Collections.Generic;


namespace Module3
{
    public class BaseClothes
    {
        public string Name { get; set; }
        public double Discount { get; set; }

        public BaseClothes(string BName, int BDiscount)
        {
            Name = BName;
            Discount = BDiscount;
        }

    }


}