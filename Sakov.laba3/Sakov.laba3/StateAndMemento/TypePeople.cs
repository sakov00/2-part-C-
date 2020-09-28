using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba3
{
    interface IState
    {
        void Handle(Person context);
    };

    class Slave : IState
    {
        private int money = 100;
        public void Handle(Person context)
        {
            Console.WriteLine("теперь бедный");
            context.State = new PoorMan();
        }
    }
    class PoorMan : IState
    {
        private int money = 200;
        public void Handle(Person context)
        {
            Console.WriteLine("теперь рабочий");
            context.State = new Worker();
        }
    }
    class Worker : IState
    {
        private int money = 300;
        public void Handle(Person context)
        {
            Console.WriteLine("теперь Аристократ");
            context.State = new Nobleman();
        }
    }
    class Nobleman : IState
    {
        private int money = 400;
        public void Handle(Person context)
        {
            Console.WriteLine("теперь король");
            context.State = new King();
        }
    }
    class King : IState
    {
        private int money = 500;
        public Memento SaveState()
        {
            Console.WriteLine("Сохранение титула. Параметры: {0} деньги", money);
            return new Memento(money);
        }
        public void RestoreState(Memento memento)
        {
            money = memento.Money;
            Console.WriteLine("Восстановление титула. Параметры: {0} деньги", money);
        }
        public void MoneyMinus()
        {
            money -= 300;
            Console.WriteLine("Вы заплатили за событие {0}", money);
        }
        public void Handle(Person context)
        {
            Console.WriteLine("Свержение!!!\n Теперь вы раб");
            context.State = new PoorMan();
        }
    }
}
