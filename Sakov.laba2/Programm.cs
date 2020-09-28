using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba2
{
    class Programm
    {
        static void Main(string[] args)
        {
            //адаптер
            Driver driver = new Driver();
            Tank tank = new Tank();
            driver.Travel(tank);
            Horse horse = new Horse();
            HorseToTransportAdapter horseTransport = new HorseToTransportAdapter(horse);
            driver.Travel(horseTransport);
            // декоратор
            People warrior1 = new Warriors();
            warrior1 = new PeopleWithArmor(warrior1);
            Console.WriteLine("Название: {0}", warrior1.Name);
            Console.WriteLine("Цена: {0}", warrior1.GetWeightEquipment());

            People warrior2 = new Cavalaryes();
            warrior2 = new PeopleWithSword(warrior2);
            Console.WriteLine("Название: {0}", warrior2.Name);
            Console.WriteLine("Цена: {0}", warrior2.GetWeightEquipment());

            People warrior3 = new Warriors();
            warrior3 = new PeopleWithArmor(warrior3);
            warrior3 = new PeopleWithSword(warrior3);
            Console.WriteLine("Название: {0}", warrior3.Name);
            Console.WriteLine("Цена: {0}", warrior3.GetWeightEquipment());
            Console.WriteLine();
            //композит
            Component World = new Map("весь мир");
            Component MapAzia = new Map("Карта Азии");
            Component MapEurope = new Map("Карта Европы");
            Component Mountains = new Place("Альпы");
            Component City1 = new Place("Париж");
            Component City2 = new Place("Минск");
            Component City3 = new Place("Пекин");
            MapAzia.Add(City3);
            MapEurope.Add(City1);
            MapEurope.Add(City2);
            World.Add(MapAzia);
            World.Add(MapEurope);
            World.Print();
            MapAzia.Remove(City3);
            Console.WriteLine();
            MapEurope.Print();
            Console.Read();
        }
    }
}
