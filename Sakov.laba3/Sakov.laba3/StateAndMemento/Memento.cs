using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba3
{
    class Memento
    {
        public int Money { get; private set; }
        public Memento(int money)
        {
            Money = money;
        }
    }
}
