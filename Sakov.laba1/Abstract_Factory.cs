using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba1
{
    abstract class AbstractFactory
    {
        public abstract Human CreateTroopsOfHuman();
        public abstract Monsters CreateTroopsOfMonsters();
    }
    class ConcreteFactory1 : AbstractFactory
    {
        public override Human CreateTroopsOfHuman()
        {
            return new InfantryOfHuman();
        }
        public override Monsters CreateTroopsOfMonsters()
        {
            return new InfantryOfMonsters();
        }
    }
    class ConcreteFactory2 : AbstractFactory
    {
        public override Human CreateTroopsOfHuman()
        {
            return new ArchersOfHuman();
        }
        public override Monsters CreateTroopsOfMonsters()
        {
            return new ArchersOfMonsters();
        }
    }
    class ConcreteFactory3 : AbstractFactory
    {
        public override Human CreateTroopsOfHuman()
        {
            return new CavalryOfHuman();
        }
        public override Monsters CreateTroopsOfMonsters()
        {
            return new CavalryOfMonsters();
        }
    }

    abstract class Human
    {
        public abstract void Attack();
        public abstract void Move();
    }
    abstract class Monsters
    {
        public abstract void Attack();
        public abstract void Move();
    }

    class InfantryOfHuman : Human
    {
        public override void Attack()
        {
            Console.WriteLine("пехота людей нападает");
        }
        public override void Move()
        {
            Console.WriteLine("пехота людей движется");
        }
    }
    class ArchersOfHuman : Human
    {
        public override void Attack()
        {
            Console.WriteLine("лучники людей стреляют");
        }
        public override void Move()
        {
            Console.WriteLine("лучники людей двигаются");
        }
    }
    class CavalryOfHuman : Human
    {
        public override void Attack()
        {
            Console.WriteLine("конница людей совершает бросок на врага");
        }
        public override void Move()
        {
            Console.WriteLine("конница людей двигается");
        }
    }

    class InfantryOfMonsters : Monsters
    {
        public override void Attack()
        {
            Console.WriteLine("пехота монстров нападает");
        }
        public override void Move()
        {
            Console.WriteLine("пехота монстров движется");
        }
    }
    class ArchersOfMonsters : Monsters
    {
        public override void Attack()
        {
            Console.WriteLine("лучники монстров стреляют");
        }
        public override void Move()
        {
            Console.WriteLine("лучники монстров двигаются");
        }
    }
    class CavalryOfMonsters : Monsters
    {
        public override void Attack()
        {
            Console.WriteLine("конница монстров совершает бросок на врага");
        }
        public override void Move()
        {
            Console.WriteLine("конница монстров двигается");
        }
    }

    class War
    {
        private Human human;
        private Monsters monsters;

        public War(AbstractFactory factory)
        {
            monsters = factory.CreateTroopsOfMonsters();
            human = factory.CreateTroopsOfHuman();
        }
        public void HumansRun()
        {
            human.Move();
        }
        public void HumansAttack()
        {
            human.Attack();
        }
        public void MonstersAttack()
        {
            monsters.Attack();
        }
        public void MonstersRun()
        {
            monsters.Move();
        }
    }
}
