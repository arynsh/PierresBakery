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

    }
    
}