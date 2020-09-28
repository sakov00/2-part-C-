using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba3
{
    class Programm
    {
        static void Main()
        {
            Exsersize1();//command
            Exsersize2();//state+memento
            Exsersize3();//observer
            Exsersize4();//stategy
            Console.Read();

        }
        static void Exsersize1()
        {
            MainHero hero = new MainHero();
            CommandToHero command = new CommandToHero(hero);
            command.SetCommand();
        }
        static void Exsersize2()
        {
            Person Man = new Person(new Person());
            Man.ChoisePerson();
            Man.ChoisePerson();
            Man.ChoisePerson();
            King king1 = new King();
            Memento safe = new Memento(0);
            safe = king1.SaveState();
            king1.MoneyMinus();
            king1.RestoreState(safe);
        }
        static void Exsersize3()
        {
            Game WoW = new Game();
            Users user2 = new Users("Евгений Саков", WoW);
            Users user1 = new Users("Иван Иваныч", WoW);
            WoW.SomeBody();
        }
        static void Exsersize4()
        {
            SingleShot type1 = new SingleShot();
            ShortBurst type2 = new ShortBurst();
            ClipShooting type3 = new ClipShooting();
            TypeOfShooting Weapon = new TypeOfShooting();
            Weapon.ExecuteAlgorithm(type1, type2, type3);
        }
    }
}
