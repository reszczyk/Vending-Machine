using System;

namespace VendingMachine.VendingMachine
{
    class Menu
    {
        public void Display()
        {
            VendingMachine machine = new VendingMachine();
            machine.FillMachine();
            bool loop = true;

            while (loop)
            {
                Console.WriteLine
                    ("\n------Menu------" +
                    "\n1. Wyświetl produkty" +
                    "\n2. Wrzuć monety" +
                    "\n3. Kup produkt" +
                    "\n4. Zwrot reszty" +
                    "\n0. Zakończ" +
                    "\nPieniądze w automacie: " + machine.cash.Money.ToString() + "zł" +
                    "\nWybierz opcję: ");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("\nLista produktów:");
                        machine.DisplayProducts();
                        Pause();
                        break;

                    case "2":
                        machine.AddCash();
                        Pause();
                        break;

                    case "3":
                        Console.WriteLine("\nWybierz kod produkt:");
                        machine.DisplayProducts();
                        Console.WriteLine("0. Anuluj");
                        machine.SellProduct();
                        Pause();
                        break;

                    case "4":
                        machine.ReturnCash();
                        Pause();
                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine("Koniec programu :)");
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("\nCoś źle kliknięte\nSpróbuj ponownie!");
                        Pause();
                        break;
                }
            }
        }

        public void Pause()
        {
            Console.WriteLine("\nEnter");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
