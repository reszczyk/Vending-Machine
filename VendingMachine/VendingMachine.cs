using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.VendingMachine
{
    class VendingMachine
    {
        public Dictionary<int, Product> Machine = new Dictionary<int, Product>();
        ProductsManager MenageProducts = new ProductsManager();
        public Cash cash = new Cash();

        public void FillMachine()
        {
            Machine = MenageProducts.Generate();
        }

        public void DisplayProducts()
        {
            Console.WriteLine("Kod \tProdukt \t Cena \tIlość");
            foreach (KeyValuePair<int, Product> Machine in this.Machine)
            {
                if(Machine.Value.Amount == 0)
                {
                    Console.WriteLine($"{Machine.Key}{"".PadRight(6)}{Machine.Value.Name}{"\t".PadLeft(7)}{Machine.Value.Price}{" zł".PadRight(6)}BRAK");
                }
                else if (Machine.Value.Amount > 0) 
                { 
                    Console.WriteLine($"{Machine.Key}{"".PadRight(6)}{Machine.Value.Name}{"\t".PadLeft(7)}{Machine.Value.Price}{" zł".PadRight(6)}{Machine.Value.Amount}"); 
                }
            }
        }

        public void SellProduct()
        {
            int choise = System.Convert.ToInt32(Console.ReadLine());

            foreach (KeyValuePair<int, Product> machine in this.Machine)
            {
                if (choise == 0) { break; }
                else if (machine.Key.Equals(choise) == true)
                {
                    if (machine.Value.Amount == 0) { Console.WriteLine("BRAK PRODUKTU!"); }
                    else
                    {
                        if(cash.DecreaseMoney(machine.Value.Price) == true)
                        {
                            Console.WriteLine($"Kupiono {machine.Value.Name}");
                            cash.DecreaseMoney(machine.Value.Price);
                            this.Machine[choise].ReduceAmount();
                        }
                        else
                        {
                            Console.WriteLine("Masz za mało pieniędzy!");
                        }
                    }
                }
            }
        }

        public void AddCash()
        {
            bool loop = true;
            while (loop)
            {
                decimal money = 0;
                Console.Clear();
                Console.WriteLine(
                    "\nWrzuć monety" +
                    "\nPieniądze w automacie:" + cash.Money +
                    "\n1. Wrzuć 5 zł" +
                    "\n2. Wrzuć 2 zł" +
                    "\n3. Wrzuć 1 zł" +
                    "\n4. Wrzuć 50 gr" +
                    "\n5. Wrzuć 20 gr" +
                    "\n6. Wrzuć 10 gr" +
                    "\n0. Wróć");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        money = 5;
                        cash.AddMoney(5);
                        break;

                    case "2":
                        money = 2;
                        cash.AddMoney(2);
                        break;

                    case "3":
                        money = 1;
                        cash.AddMoney(1);
                        break;

                    case "4":
                        money = 0.50m;
                        cash.AddMoney(0.50m);
                        break;

                    case "5":
                        money = 0.20m;
                        cash.AddMoney(0.20m);
                        break;

                    case "6":
                        money = 0.10m;
                        cash.AddMoney(0.10m);
                        break;

                    case "0":
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("\nNie ma takiej opcji!");
                        break;
                }
            }
        }

        public void ReturnCash()
        {
            cash.ReturnMoney();
        }
    }
}
