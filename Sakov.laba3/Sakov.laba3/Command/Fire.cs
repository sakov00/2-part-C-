using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba3
{
    class Fire : ICommand
    {
        MainHero Person;
        public Fire(MainHero r)
        {
            Person = r;
        }
        public void Active()
        {
            Console.WriteLine("начать огонь");
        }
        public void InActive()
        {
            Console.WriteLine("прекратить огонь");
        }

    }
}
