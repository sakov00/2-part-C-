using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba2
{
    public interface IComponent 
    {
        void Display();
        void Add(Component c);
        void Remove(Component c);
        void Find(Component c);
    }
    public abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public virtual void Add(Component component) { }

        public virtual void Remove(Component component) { }

        public virtual void Print()
        {
            Console.WriteLine(name);
        }
    }
    class Map : Component
    {
        private List<Component> components = new List<Component>();

        public Map(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine("карта: " + name);
            Console.WriteLine("Место на карте:");
            for (int i = 0; i < components.Count; i++)
            {
                components[i].Print();
            }
        }
    }

    class Place : Component
    {
        public Place(string name)
                : base(name)
        { }
    }
}
