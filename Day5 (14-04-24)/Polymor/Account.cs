using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymor
{
    public abstract class Account
    {
       
        public abstract void Deposit(double amount);
       public abstract void Withdraw(double amount);
    }

}
