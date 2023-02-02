using System;
using System.Collections.Generic;
using System.Text;

namespace CRPGProject
{
    public class InventoryItem
    {
        public Items Details;
        public int Quantity;
        public InventoryItem(Items details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
