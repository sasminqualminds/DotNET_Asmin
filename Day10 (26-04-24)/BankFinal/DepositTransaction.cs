using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankFinal
{
    internal class DepositTransaction:Transaction
    {
        public Account _account;
        public decimal _amount;
        public bool _executed;
        public bool _success;
        public bool _reversed;
       // public bool Success { get { return _success; } }
        //public bool Executed { get { return _executed; } }
        //public bool Reversed { get { return _reversed; } }

        public DepositTransaction(Account account, decimal amount):base(amount)
        {
            _account = account;
            _amount = amount;
        }

        public override void Execute()
        {
            base.Execute();
            _success = _account.Deposit(_amount);
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

            // Reversing a deposit means withdrawing the deposited amount from the account
            _reversed = true;
            _success = _account.Withdraw(_amount);

        }

        public override void print()
        {
            Console.WriteLine($"Success: {_success}, Amount Deposited in {_account.name}: {_amount}");
        }

        public override bool Success()
        {
            return _success;
        }

        public override bool Reversed()
        {
            return _reversed;
        }

        public override bool Executed()
        {
            return _executed;
        }
    }

}
