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
            
        }

    }
    
}