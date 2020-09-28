using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba5
{
    public class Adress
    {
        public string Country { get;  set; }
        public string Town { get;  set; }
        public string Street { get;  set; }
        public int House { get;  set; }
        public int Corps { get;  set; }
        public int NumberApartment { get;  set; }
        public Adress() { }
        public override string ToString()
        {
            return "Country = " + Country + " \r\n Town = " + Town + "\r\n Street = " + Street + "\r\n House = " + House +
                "\r\n Corps = " + Corps + "\r\n NumberApartment = " + NumberApartment;
        }
    }
}
