using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba3
{
    public interface IStrategy
    {
        void Shoot();
    }

    public class SingleShot : IStrategy
    {
        public void Shoot()
        { Console.WriteLine("одиночная стрельба"); }
    }

    public class ShortBurst : IStrategy
    {
        public void Shoot()
        { Console.WriteLine("стрельба короткими очередями"); }
    }
    public class ClipShooting : IStrategy
    {
        public void Shoot()
        { Console.WriteLine("стрельба зашимом"); }
    }

    public class TypeOfShooting
    {
        public IStrategy Type { get; set; }

        public void ExecuteAlgorithm(IStrategy type1, IStrategy type2, IStrategy type3)
        {
            Console.WriteLine("выберите тип стрельбы?");
            Console.WriteLine("1. SingleShot");
            Console.WriteLine("2. ShortBurst");
            Console.WriteLine("3. ClipShooting");
            int k = int.Parse(Console.ReadLine());
            switch (k)
            {
            case 1:
                    Type = type1;
                    break;
            case 2:
                    Type = type2;
                    break;
            case 3:
                    Type = type3;
                    break;
                default:
                    Console.WriteLine("давай выбирай");
                    break;

            }
            Type.Shoot();
        }
    }

}
