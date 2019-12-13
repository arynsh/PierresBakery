using System;
using System.Collections.Generic;

namespace Bakery
{
    class BreadClass
    {
        public string BreadQuantity { get; set; }
        public int Price { get; set; }

        public Bread(int breadQuantity, int price)
        {
            BreadQuantity = breadQuantity;
            Price = price;
        }
        
        public int CalculateCost()
        {

        }

    }

    class PastryClass
    {
        public string PastryQuantity { get; set; }
        public int Price { get; set; }

        public Pastry(int pastryQuantity, int price)
        {
            PastryQuantity = pastryQuantity;
            Price = price;
        }
        
        public int CalculateCost()
        {
            int cost;

            if (PastryQuantity <= 2)
            {
                cost = PastryQuantity * 2;
            }
            else
            {
                cost = (PastryQuantity / 3)   // 13 pastries; 13 / 3 = 4 remainder 1; 4 x 5 = 20 plus 1 x 2 = 22;
            }
        }

    }
    
}
