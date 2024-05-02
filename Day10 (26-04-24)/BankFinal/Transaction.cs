using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankFinal
{
    internal abstract class Transaction
    {
        protected decimal _amount;
        bool _executed;
        bool _reversed;
        private DateTime _dateStamp;
        

        public Transaction(decimal amount)
        {
            _amount = amount;
        }

        public abstract bool Executed();

        public abstract bool Reversed();
        
        
        public abstract bool Success();


        public abstract void print();

        public virtual void Execute()
        {
            if (_executed)
            {
                throw new InvalidOperationException("Transaction has already been executed.");
            }

            _executed = true;
            _dateStamp = DateTime.Now;
        }

        public virtual void RollBack()
        {
            if (!_executed)
            {
                throw new InvalidOperationException("Transaction has not been executed yet.");
            }

            if (_reversed)
            {
                throw new InvalidOperationException("Transaction has already been reversed.");
            }

            _reversed = true;
        }
        

    }   
}
