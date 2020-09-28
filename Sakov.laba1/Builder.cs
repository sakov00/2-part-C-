using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba1
{
    //существо
    class Сreature
    {
        // тип войска у существа
        public string TypeCreature { get; set; }
    }
    //экипировка
    class Equipment
    {
        public string TypeEquipment { get; set; }
    }

    class Warrior
    {
        public Сreature Сreature { get; set; }
        public Equipment Equipment { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Сreature != null)
                sb.Append("тип войска: " + Сreature.TypeCreature + "\n");
            if (Equipment != null)
                sb.Append("тип экипировки: " + Equipment.TypeEquipment + " \n");
            return sb.ToString();
        }
        public Warrior Clone()
        {
            Console.WriteLine("Клон");
            Warrior wary = new Warrior();
            wary.Сreature = Сreature;
            wary.Equipment = Equipment;
            return wary;
        }
    }
    abstract class WarriorBuilder
    {
        public Warrior Warrior { get; private set; }
        public void CreateWarrior()
        {
            Warrior = new Warrior();
        }
        public abstract void SetСreature();
        public abstract void SetEquipment();
    }
    // процесс
    class Create
    {
        public Warrior CreateWarror(WarriorBuilder warriorBuilder)
        {

            warriorBuilder.CreateWarrior();
            warriorBuilder.SetСreature();
            warriorBuilder.SetEquipment();
            return warriorBuilder.Warrior;
        }
    }
    // создание
    class ArcherWarriorBuilder : WarriorBuilder
    {
        public override void SetСreature()
        {
            Warrior.Сreature = new Сreature { TypeCreature = "Archer" };
        }
        public override void SetEquipment()
        {
            Warrior.Equipment = new Equipment { TypeEquipment = "доспех + лук" };
        }
    }
    class SoldierWarriorBuilder : WarriorBuilder
    {
        public override void SetСreature()
        {
            Warrior.Сreature = new Сreature { TypeCreature = "Soldier" };
        }
        public override void SetEquipment()
        {
            Warrior.Equipment = new Equipment { TypeEquipment = "доспех + щит + меч" };
        }
    }
    //окончательное создание
    class CavalryWarriorBuilder : WarriorBuilder
    {
        public override void SetСreature()
        {
            Warrior.Сreature = new Сreature { TypeCreature = "Cavalry" };
        }
        public override void SetEquipment()
        {
            Warrior.Equipment = new Equipment { TypeEquipment = "конница + воин" };
        }
    }
}
