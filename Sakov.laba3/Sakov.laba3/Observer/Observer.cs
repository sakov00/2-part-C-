using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba3
{
    interface IObserver
    {
        void Noty(StockInfo ob);
    }
    class StockInfo
    {
        public string Notifications { get; set; }
        public string Updates { get; set; }
    }

    class Users : IObserver
    {
        public string Name { get; set; }
        IObservable notice;
        public Users(string name, IObservable obs)
        {
            Name = name;
            notice = obs;
            notice.RegisterObserver(this);
        }
        public void Noty(StockInfo ob)
        {
            StockInfo sInfo =ob;

            if (sInfo.Notifications != null)
                Console.WriteLine("пользователь {0} получил оповещение :{1}", Name, sInfo.Notifications);
            else
                Console.WriteLine("ничего не произошло");

            if (sInfo.Updates != null)
                Console.WriteLine("пользователь {0} получил оповещение :{1}", Name, sInfo.Updates);
            else
            Console.WriteLine("ничего не произошло");

        }
    }
}
