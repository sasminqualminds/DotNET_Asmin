using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asmin_CSharp101
{
    // creating an interface
    internal interface IAccount
    {
        void Deposit(double amount);
        void Withdraw(double amount);   
        double GetBalance();
    }
}
