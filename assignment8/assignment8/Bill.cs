using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8
{
   
    public class Bill
    {
        double tax = 0.09;
        
        //constructor
        public Bill ()
        {
            Amount = 0;
            TipPercent = 0;
        }
        public Bill(double amount, double tipPercent)
        {
            Amount = amount;
            TipPercent = tipPercent;
        }

        public double Amount{ get; set; }
        public double TipPercent { get; set; }

        public double Total()
        {
            double total = tax * Amount + Amount;
            return total;
        }

        public double TotalwithTip()
        {
            double totalwithtip = (tax * Amount  + Amount) * TipPercent + (tax * Amount + Amount);
            return totalwithtip;
        }
    }
}



