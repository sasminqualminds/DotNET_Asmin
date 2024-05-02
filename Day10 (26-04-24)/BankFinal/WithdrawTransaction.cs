using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankFinal
{
    internal class WithdrawTransaction:Transaction
    {
        public Account _account;
        public decimal _amount;
        public bool _executed;
        public bool _success;
        public bool _reversed;
        //public bool Success { get; set; }
        //public bool Executed { get; set; }
        //public bool Reversed { get; set; }
     
        public WithdrawTransaction(Account account, decimal amount) : base(amount)
        {  _account = account; 
            _amount = amount;
        }
        
        public override void Execute()
        {
            base.Execute();
            _success = _account.Withdraw(_amount);
            _executed = true;
        }

        public override void RollBack()
        {
            if (!_executed)
            {
                throw new InvalidOperationException("Cannot execute transaction");
            }

            if (_reversed)
            {
                throw new InvalidOperationException("Transaction has already been reversed");
            }

            // Reversing a withdrawal means depositing the withdrawn amount back to the account
            _reversed = true;
            _success = _account.Deposit(_amount);

        }

        public override void print()
        {
            Console.WriteLine($"Success: {_success}, Amount withdrawn from {_account.name}: {_amount}");
            
        }

        
        public override bool Success()
        {
            return _success;
        }

        public override bool Executed()
        {
            return _executed;
        }

        public override bool Reversed()
        {
            return _reversed;
        }
    }
}
