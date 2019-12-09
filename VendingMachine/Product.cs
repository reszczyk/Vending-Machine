using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.VendingMachine
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

        public bool ReduceProduct()
        {
            if (this.Amount > 0)
            {
                this.Amount--;
                return true;
            }
            return false;
        }
    }
}
