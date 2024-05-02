using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankFinal
{
    internal class TransferTransaction:Transaction
    {
        private Account _toAccount;

        public Account _fromAccount;
        public decimal _amount;
        public DepositTransaction _theDeposit;
        public WithdrawTransaction _theWithdraw;
        public bool _executed;
        public bool _success;
        public bool _reversed;
        // public bool Success { get { return _success; } set { _success = value; } }
        //public bool Executed { get; set; }
        //public bool Reversed { get; set; }

        public TransferTransaction(Account fromAccount, Account toAccount,decimal amount):base(amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _amount = amount;
            
        }

        public override void Execute()
        {
            _theWithdraw = new WithdrawTransaction(_fromAccount, _amount);
            _theDeposit = new DepositTransaction(_toAccount, _amount);
            _theWithdraw.Execute();
            if (_theWithdraw._success)
            {
                _theDeposit.Execute();
                _success = _theDeposit._success;
                _executed = _theDeposit.Executed();
            }
        }
        public override void RollBack()
        {
            if (!_executed)
            {
                throw new InvalidOperationException("Cannot roll back transaction as it has not been executed.");
            }

            if (_reversed)
            {
                throw new InvalidOperationException("Transaction has already been reversed.");
            }

            _reversed = true;

            if (_theDeposit != null && _theWithdraw != null)
            {
                _theDeposit.RollBack();
                _theWithdraw.RollBack();
            }
        }

        public override void print()
        {
            Console.WriteLine($"success:   {_success}  \nAmount Transferred \nFrom bank: {_fromAccount.name} : {_fromAccount.Balance} \nTo bank: { _toAccount.name} : {_toAccount.Balance}");

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
