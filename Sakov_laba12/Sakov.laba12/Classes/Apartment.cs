using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba12
{
    class Apartment
    {
        public int Id { get; set; }
        public int Area { get; set; }
        public int CountRoom { get; set; }
        public DateTime YearsBuilder { get; set; }
        public string TypeMaterial { get; set; }
        public int Floor { get; set; }
        public Adress Adress { get; set; }
        public Apartment(int area, int countroom, DateTime yearsbuilder, string typematerial, int floor, Adress adress)
        {
            Area = area;
            CountRoom = countroom;
            YearsBuilder = yearsbuilder;
            TypeMaterial = typematerial;
            Floor = floor;
            Adress = adress;
        }
        public Apartment() { }
        public override string ToString()
        {
            return $"Площадь:{Area},\r\nГод постройки:{YearsBuilder},\r\nТип материала:{TypeMaterial},\r\n Этаж:{Floor},\r\n" +
                $"Кол-во комнат:{CountRoom}\r\n";
        }
    }
}
