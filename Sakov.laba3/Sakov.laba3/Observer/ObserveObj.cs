using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba3
{

    interface IObservable
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    class Game : IObservable
    {
        public StockInfo sInfo; // 

        List<IObserver> observers;
        public Game()
        {
            observers = new List<IObserver>();
            sInfo = new StockInfo();
        }
        public void RegisterObserver(IObserver o)
        {

            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Noty(sInfo);
            }
        }

        public void SomeBody()
        {
            string up = "вышло обновление";
            string noty = "вышло уведомление";
            sInfo.Notifications = up;
            sInfo.Updates = noty;
            NotifyObservers();
        }
    }
}
