using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.VendingMachine
{
    class Cash
    {
        public decimal Money { get; set; } = 0;

        public void AddMoney(decimal money)
        {
            this.Money += money;
        }

        public bool DecreaseMoney(decimal money)
        {
            if((this.Money - money) < 0) { return false; }
            else
            {
                this.Money -= money;
                return true;
            }
        }

        public void ReturnMoney()
        {
            Console.WriteLine("Wydano:");
            this.Money = ReturnZl(5, this.Money, "5");
            this.Money = ReturnZl(2, this.Money, "2");
            this.Money = ReturnZl(1, this.Money, "1");
            this.Money = ReturnGr(50, this.Money, "50");
            this.Money = ReturnGr(20, this.Money, "20");
            this.Money = ReturnGr(10, this.Money, "10");
        }

        public decimal ReturnZl(int amount, decimal money, string coin)
        {
            int penny = Decimal.ToInt32(money/amount);
            if (penny != 0) { Console.WriteLine(penny + "x " + coin + "zł"); }
            return money -= Convert.ToDecimal(amount * penny);
        }
        public decimal ReturnGr(int amount, decimal money, string coin)
        {
            money *= 100;
            int penny = Decimal.ToInt32(money / amount);
            if (penny != 0) { Console.WriteLine(penny + "x " + coin + "gr"); }
            money -= Convert.ToDecimal(amount * penny);
            return money /= 100;
        }
    }
}