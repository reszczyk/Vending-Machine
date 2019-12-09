using System.Collections.Generic;

namespace VendingMachine.VendingMachine
{
    class ProductsManager
    {
        Dictionary<int, Product> products = new Dictionary<int, Product>();
        public int index { get; set; } = 10;

        public Dictionary<int, Product> Generate()
        {
            products.Add(KeyGenerator(), new Product { Name = "Coca-Cola", Price = 2.50m, Amount = 1 });
            products.Add(KeyGenerator(), new Product { Name = "Cola Zero", Price = 2.00m, Amount = 3 });
            products.Add(KeyGenerator(), new Product { Name = "Cola Lime", Price = 2.80m, Amount = 1 });
            products.Add(KeyGenerator(), new Product { Name = "Pepsi", Price = 2.80m, Amount = 4 });
            products.Add(KeyGenerator(), new Product { Name = "Powerrade", Price = 3.50m, Amount = 1 });
            products.Add(KeyGenerator(), new Product { Name = "Sprite", Price = 2.50m, Amount = 4 });
            products.Add(KeyGenerator(), new Product { Name = "Fanta", Price = 3.00m, Amount = 0 });
            products.Add(KeyGenerator(), new Product { Name = "Cappy", Price = 3.50m, Amount = 4 });
            return products;
        }

        public int KeyGenerator()
        {
            if(index == 10) 
            {
                index++;
                return index; 
            }
            if (index % 5 == 0)
            {
                index += 6;
                return index;
            }
            else
            {
                index++;
                return index;
            }
        }
    }
}
