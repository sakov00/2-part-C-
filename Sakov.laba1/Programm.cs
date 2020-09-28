using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba1
{
    class Programm
    {

        static void Main()
        {
            War FirstFight = new War(new ConcreteFactory2());
            FirstFight.MonstersAttack();
            FirstFight.MonstersRun();
            FirstFight.HumansAttack();
            FirstFight.HumansRun();
            ////////
            SomeBody human = new SomeBody();
            human.Launch("Rogarius");
            Console.WriteLine(human.Somy.Name);

            human.Somy = Hero.getInstance("Roman");
            Console.WriteLine(human.Somy.Name);
            //////
            Create creater = new Create();

            WarriorBuilder builder = new SoldierWarriorBuilder();
            Warrior soldier = creater.CreateWarror(builder);
            Console.WriteLine(soldier.ToString());

            builder = new ArcherWarriorBuilder();
            Warrior archer = creater.CreateWarror(builder);
            Console.WriteLine(archer.ToString());
            //////
            Warrior mainsold = soldier.Clone();
            Console.WriteLine(mainsold.ToString());

            Warrior clone = archer.Clone();
            Console.WriteLine(clone.ToString());



            Console.Read();
        }
    }
}
