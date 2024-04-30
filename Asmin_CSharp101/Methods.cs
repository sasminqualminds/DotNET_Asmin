using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asmin_CSharp101
{
    internal class Methods
    {
        public void Deposit(IAccount account,double amount)
        {
            account.Deposit(amount);
        }
        public void Withdraw(IAccount account,double amount)
        {
            account.Withdraw(amount);
        }
    }
}
