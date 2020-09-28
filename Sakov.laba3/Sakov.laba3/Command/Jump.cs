using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba3
{
    class Jump : ICommand
    {
        MainHero Person;
        public Jump(MainHero r)
        {
            Person = r;
        }
        public void Active()
        {
            Console.WriteLine("начать прыгать");
        }
        public void InActive()
        {
            Console.WriteLine("прекратить прыгать");
        }

    }
}
