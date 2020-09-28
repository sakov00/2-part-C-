using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Sakov.laba5
{
    public class Apartment
    {
        public int Area { get;  set; }
        public int CountRoom { get;  set; }
        public DateTime YearsBuilder { get;  set; }
        public string TypeMaterial { get;  set; }
        public int Floor { get;  set; }
        public bool Kitchen { get;  set; }
        public bool Hall { get;  set; }
        public bool Bedroom { get;  set; }
        public bool Bathroom { get;  set; }
        public Adress Adress { get;  set; }
        public Apartment() { }
        public override string ToString()
        {
            return $"Площадь:{Area},\r\nГод постройки:{YearsBuilder},\r\nТип материала:{TypeMaterial},\r\n Этаж:{Floor},\r\n" +
                $"Кол-во комнат:{CountRoom},\r\nНаличие кухни:{Kitchen},\r\nНаличие зала:{Hall},\r\nНаличие спальни:{Bedroom}\r\n" +
                $"Наличие ванной:{Bathroom}\r\nАдрес:{Adress}\r\n";
        }
        public void SaveIn()
        {
            using (StreamWriter fs = new StreamWriter("user" + ".json", false, Encoding.Default))
            {
                fs.Write(JsonConvert.SerializeObject(this, Formatting.Indented));
            }
        }
        public void SaveOut()
        {
            using (StreamReader sr = new StreamReader("user" + ".json"))
            {
                string str = sr.ReadToEnd();
                Apartment apart = JsonConvert.DeserializeObject<Apartment>(str);
                //persons.Add(person);
                MessageBox.Show(str);
            }

        }
        public void Clone(Apartment apart,Adress adress)
        {
            Area = apart.Area;
            CountRoom = apart.Area;
            YearsBuilder = apart.YearsBuilder;
            TypeMaterial = apart.TypeMaterial;
            Floor = apart.Floor;
            Kitchen = apart.Kitchen;
            Hall = apart.Hall;
            Bedroom = apart.Bedroom;
            Bathroom = apart.Bathroom;
            CountRoom= apart.CountRoom;
            Adress.Country = apart.Adress.Country;
            Adress.Town = apart.Adress.Town;
            Adress.Street = apart.Adress.Street;
            Adress.House = apart.Adress.House;
            Adress.Corps = apart.Adress.Corps;
            Adress.NumberApartment = apart.Adress.NumberApartment;

        }
    }
}
