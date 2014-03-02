using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    // both accaunt can deposit money
    // thats why I am making the interface IDepositable
    public interface IDepositable
    {
        void Deposit(decimal money);
    }
}
