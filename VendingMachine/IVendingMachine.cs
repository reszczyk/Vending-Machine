using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.VendingMachine
{
    interface IVendingMachine
    {
        public void FillMachine() { }
        public void DisplayProducts() { }
        public void SellProduct() { }
        public void AddCash() { }
        public void ReturnCash() { }
    }
}
