using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba3
{
    class Person:IState
    {
        public IState State { get; set; }
        public Person()
        {}
        public Person(Person state)
        { 
            State = state; 
        }
        public void ChoisePerson()
        {
            State.Handle(this);
        }
        public void Handle(Person context)
        {

            Console.WriteLine("выберите за кого начать?");
            Console.WriteLine("1. Slave");
            Console.WriteLine("2. PoorMan");
            Console.WriteLine("3. Worker");
            Console.WriteLine("4. Nobleman");
            Console.WriteLine("5. King");
            
            int k = int.Parse(Console.ReadLine());
            switch (k)
            {
                case 1:
                    context.State = new Slave();
                    break;
                case 2:
                    context.State = new PoorMan();
                    break;
                case 3:
                    context.State = new Worker();
                    break;
                case 4:
                    context.State = new Nobleman();
                    break;
                case 5:
                    context.State = new King();
                    break;
                default:
                    Console.WriteLine("You must give Hero");
                    { break; }
            }
        }
    }
}
