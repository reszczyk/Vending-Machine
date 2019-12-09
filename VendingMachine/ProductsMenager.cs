using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.VendingMachine
{
    class ProductsMenager
    {
        Dictionary<int, Product> products = new Dictionary<int, Product>();
        public int index { get; set; } = 10;

        public Dictionary<int, Product> Generate()
        {
            products.Add(KeyGenerator(), new Product { Name = "M&M's", Price = 1.50m, Amount = 1 });
            products.Add(KeyGenerator(), new Product { Name = "Lay's", Price = 2.50m, Amount = 3 });
            products.Add(KeyGenerator(), new Product { Name = "Crunchips", Price = 1.50m, Amount = 1 });
            products.Add(KeyGenerator(), new Product { Name = "Pringles", Price = 2.50m, Amount = 4 });
            products.Add(KeyGenerator(), new Product { Name = "Bounty", Price = 1.50m, Amount = 1 });
            products.Add(KeyGenerator(), new Product { Name = "Mars", Price = 2.50m, Amount = 4 });
            products.Add(KeyGenerator(), new Product { Name = "Snicers", Price = 1.50m, Amount = 0 });
            products.Add(KeyGenerator(), new Product { Name = "Pepsi", Price = 2.50m, Amount = 4 });
            return products;
        }

        public void ReduceProduct(int key)
        {
           /* if (key.Equals(this.products.) > 0)
            {
                product.Amount -= product.Amount;
            }
            else
            {

            }
            */
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
