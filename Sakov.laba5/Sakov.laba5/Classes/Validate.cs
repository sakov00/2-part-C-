using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sakov.laba5.Classes
{
    class Validate
    {
        public bool validate(string regextext,string validatetext)
        {
            Regex regex = new Regex(regextext);
            MatchCollection matches = regex.Matches(validatetext);
            return matches.Count > 0;
        }
    }
}
