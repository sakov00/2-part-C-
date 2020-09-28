using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba1
{
    class SomeBody
    {
        public Hero Somy { get; set; }
        public void Launch(string Name)
        {
            Somy = Hero.getInstance(Name);
        }
    }
    class Hero
    {

        public static Hero instance;
        public string Name { get; private set; }
        private Hero(string name)
        {
            Name = name;
        }

        public static Hero getInstance(string name)
        {
            if (instance == null)
                instance = new Hero(name);
            return instance;
        }
    }
}
