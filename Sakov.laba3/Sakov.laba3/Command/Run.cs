using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba3
{
    class Run : ICommand
    {
        MainHero Person;
        public Run(MainHero r)
        {
            Person = r;
        }
        public void Active()
        {
            Console.WriteLine("начать бежать");
        }
        public void InActive()
        {
            Console.WriteLine("прекратить бежать");
        }

    }
}
