using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba2
{
    interface ITransport
    {
        void Drive();
    }
    class Tank : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("танк едет по дороге");
        }
    }
    class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
    interface IAnimal
    {
        void Move();
    }
    class Horse : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("животное идёт по дороге");
        }
    }

    class HorseToTransportAdapter : ITransport
    {
        Horse Horse;
        public HorseToTransportAdapter(Horse c)
        {
            Horse = c;
        }

        public void Drive()
        {
            Horse.Move();
        }
    }
}
