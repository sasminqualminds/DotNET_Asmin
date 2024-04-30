using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymor
{
    public class Bank
    {
        public void PerformTransaction(Account account, double amount)
        {          
            if (amount >= 0)
            {
                account.Deposit(amount);
            }
            else
            {
                account.Withdraw(-amount);
            }
        }
    }
}
