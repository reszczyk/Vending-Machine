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
            if((this.Money -= money) < 0) { return false; }
            else
            {
                this.Money -= money;
                return true;
            }
        }

        public void ReturnMoney()
        {
            Console.WriteLine("Wydano:");
            int zl5 = 0;
            int zl2 = 0;
            int zl1 = 0;
            int gr50 = 0;
            int gr20 = 0;
            int gr10 = 0;

            zl5 = Decimal.ToInt32(this.Money / 5);
            if(zl5 != 0) { Console.WriteLine(zl5 + "x 5zł"); };
            this.Money -= Convert.ToDecimal(5 * zl5);

            zl2 = Decimal.ToInt32(this.Money / 2);
            if (zl2 != 0) { Console.WriteLine(zl2 + "x 2zł"); };
            this.Money -= Convert.ToDecimal(2 * zl2);

            zl1 = Decimal.ToInt32(this.Money / 1);
            if (zl1 != 0) { Console.WriteLine(zl1 + "x 1zł"); };
            this.Money -= Convert.ToDecimal(zl1);

            gr50 = Decimal.ToInt32(this.Money / 0.5m);
            if (gr50 != 0) { Console.WriteLine(gr50 + "x 50gr"); };
            this.Money -= Convert.ToDecimal(0.5 * gr50);

            gr20 = Decimal.ToInt32(this.Money / 0.2m);
            if (gr20 != 0) { Console.WriteLine(gr20 + "x 20gr"); };
            this.Money -= Convert.ToDecimal(0.2 * gr20);

            gr10 = Decimal.ToInt32(this.Money / 0.1m);
            if (gr10 != 0) { Console.WriteLine(gr10 + "x 10 gr"); };
            this.Money -= Convert.ToDecimal(0.1 * gr10);
        }
    }
}