using System;

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
            if ((this.Money - money) < 0) { return false; }
            else
            {
                this.Money -= money;
                return true;
            }
        }

        public void ReturnMoney()
        {
            Console.WriteLine("Automat zwrócił:");
            this.Money = ReturnCoin(500, this.Money, "5zł");
            this.Money = ReturnCoin(200, this.Money, "2zł");
            this.Money = ReturnCoin(100, this.Money, "1zł");
            this.Money = ReturnCoin(50, this.Money, "50gr");
            this.Money = ReturnCoin(20, this.Money, "20gr");
            this.Money = ReturnCoin(10, this.Money, "10gr");
        }

        public decimal ReturnCoin(int amount, decimal money, string coin)
        {
            money *= 100;
            int penny = Decimal.ToInt32(money / amount);
            if (penny != 0) { Console.WriteLine(penny + "x " + coin); }
            money -= Convert.ToDecimal(amount * penny);
            return money /= 100;
        }
    }
}