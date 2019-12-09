using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.VendingMachine
{
    class VendingMachine
    {
        public Dictionary<int, Product> Machine = new Dictionary<int, Product>();
        ProductsMenager MenageProducts = new ProductsMenager();

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
                Console.WriteLine($"{Machine.Key}{"".PadRight(6)}{Machine.Value.Name}{"\t".PadLeft(7)}{Machine.Value.Price}{" zł".PadRight(6)}{Machine.Value.Amount}");
            }
        }

        public void SellProduct()
        {
            string choise = Console.ReadLine();
            foreach (KeyValuePair<int, Product> Machine in this.Machine)
            {
                if (choise == "0") { }
                else if (choise != Machine.Key.ToString())
                {
                    Console.Clear();
                    Console.WriteLine("Nie ma takiego produktu");
                }
                else if (choise == Machine.Key.ToString())
                {
                    if (Machine.Value.Amount == 0) { Console.WriteLine("BRAK PRODUKTU!"); }
                    else
                    {
                        Console.WriteLine($"Kupiono {Machine.Value.Name}");
                        cash.DecreaseMoney(Machine.Value.Price);
                       // Machine.ReduceProducy(choise);
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
