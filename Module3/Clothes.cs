using System;
using System.Collections.Generic;


namespace Module3
{
    public class Clothes
    {
        double price;

        public string Name { get; set; }
        public double Price
        {
            get
            {
                return price + (price * BaseClothes.Discount / 100);
            }
        }
        public BaseClothes BaseClothes { get; private set; }

        public Clothes(string ClothesName, double ClothesPrice, BaseClothes baseClothes)
        {
            Name = ClothesName;
            price = ClothesPrice;
            BaseClothes = baseClothes;

        }
    }
}