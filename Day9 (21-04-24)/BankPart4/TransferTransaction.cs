using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUpdate
{
    internal class TransferTransaction
    {
        private Account _toAccount;

        private Account _fromAccount;
        private decimal _amount;
        private DepositTransaction _theDeposit;
        private WithdrawTransaction _theWithdraw;
        private bool _executed;
        private bool _success;
        private bool _reversed;
        public bool Success { get { return _success; } set { _success = value; } }
        public bool Executed { get { return _success; } set { _success = value; } }
        public bool Reversed { get { return _success; } set { _success = value; } }

        public TransferTransaction(Account fromAccount, Account toAccount, decimal amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _amount = amount;
        }

        public void Execute()
        {
            
            _theWithdraw = new WithdrawTransaction(_fromAccount, _amount);
            _theDeposit = new DepositTransaction(_toAccount, _amount);
            _theWithdraw.Execute();
            if (_theWithdraw.Success)
            {
                _theDeposit.Execute();
                Success= _theDeposit.success;
                Executed= _theDeposit.executed;
            }

            //withdrawTransaction.RollBack();

            
            //withdrawTransaction.Print();
        }



        
        public void Print()
        {
            Console.WriteLine($"Transfer Transaction Details:");
            Console.WriteLine($"Amount: {_amount}");
            Console.WriteLine($"Executed: {Executed}");
            Console.WriteLine($"Success: {Success}");

            if (_reversed)
            {
                Console.WriteLine("Note: This transaction has been reversed.");
            }
        }
    }
}
