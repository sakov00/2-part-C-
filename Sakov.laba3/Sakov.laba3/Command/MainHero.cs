using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba3
{
    class MainHero
    {
        ICommand command;
        public void SetCommand(ICommand c)
        {
            command = c;
        }
        public void Begin()
        {
            command.Active();
        }
        public void Cancel()
        {
            command.InActive();
        }
    }
}
