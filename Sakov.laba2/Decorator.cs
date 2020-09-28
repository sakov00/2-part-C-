using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba2
{
    abstract class People
    {
        public People(string n)
        {
            Name = n;
        }
        public string Name { get; protected set; }
        public abstract int GetWeightEquipment();
    }

    class Warriors : People
    {
        public Warriors() 
            : base("воины")
        { }
        public override int GetWeightEquipment()
        {
            return 4;
        }
    }
    class Cavalaryes : People
    {
        public Cavalaryes()
            : base("кавалерия")
        { }
        public override int GetWeightEquipment()
        {
            return 8;
        }
    }

    abstract class PeopleDecorator : People
    {
        protected People People;
        public PeopleDecorator(string n, People People) : base(n)
        {
            this.People = People;
        }
    }

    class PeopleWithArmor : PeopleDecorator
    {
        public PeopleWithArmor(People p)
            : base(p.Name + ", с бронёй", p)
        { }

        public override int GetWeightEquipment()
        {
            return People.GetWeightEquipment() + 30;
        }
    }

    class PeopleWithSword : PeopleDecorator
    {
        public PeopleWithSword(People p)
            : base(p.Name + ", с мечом", p)
        { }

        public override int GetWeightEquipment()
        {
            return People.GetWeightEquipment() + 5;
        }
    }
}
