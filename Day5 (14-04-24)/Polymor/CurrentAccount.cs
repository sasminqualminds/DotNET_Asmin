using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymor
{
    public class CurrentAccount : Account
    {
        public override void Deposit(double amount)
        {
            Console.WriteLine($"Depositing {amount:C} into current account");
        }

        public override void Withdraw(double amount)
        {
            Console.WriteLine($"Withdrawing {amount:C} from current account");
        }
    }
}
