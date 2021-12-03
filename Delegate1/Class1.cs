using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    class Account
    {
        int _sum; // variable keep money
        public Account(int sum)
        {
            _sum = sum;
        }
        public int CurrentSum
        {
            get { return _sum; }
        }
        public void Put(int sum)
        {
            _sum += sum;
        }
        public void Withdraw(int sum)
        {
            if (sum <= _sum)
            {
                _sum -= sum;
                if (_del != null)
                    _del($"{sum} withdrawn from the account");
            }
            else 
            {
                if (_del != null)
                    _del("Not enough money in the account");
               
            }
        }
        public delegate void AccountStateHandler(string message);
        AccountStateHandler _del;//create variable of delegate
        //registration of delegate
        public void RegisterHandler(AccountStateHandler del)
        {
            _del = del;
        }
    }
}
