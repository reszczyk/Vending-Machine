namespace VendingMachine.VendingMachine
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

        public void ReduceAmount()
        {
            if (this.Amount > 0)
            {
                this.Amount--;
            }
        }
    }
}