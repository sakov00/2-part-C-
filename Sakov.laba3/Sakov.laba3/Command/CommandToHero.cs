using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakov.laba3
{
    class CommandToHero
    {
            MainHero command;
            public CommandToHero(MainHero r)
            {
            command = r;
            }
        public void SetCommand()
        {
            string Word="9";
            while (Word != "0")
            {
                Word = Console.ReadLine();
                if (Word == "w")
                {
                    Run run1 = new Run(command);
                    command.SetCommand(run1);
                    command.Begin();
                }
                if (Word == "bw")
                {
                    Run run2 = new Run(command);
                    command.SetCommand(run2);
                    command.Cancel();
                }
                if (Word == " ")
                {
                    Jump jumpy1 = new Jump(command);
                    command.SetCommand(jumpy1);
                    command.Begin();
                }
                if (Word == "b ")
                {
                    Jump jumpy2 = new Jump(command);
                    command.SetCommand(jumpy2);
                    command.Cancel();
                }
                if (Word == "f")
                {
                    Fire fire1 = new Fire(command);
                    command.SetCommand(fire1);
                    command.Begin();
                }
                if (Word == "bf")
                {
                    Fire fire2 = new Fire(command);
                    command.SetCommand(fire2);
                    command.Cancel();
                }
            }
        }
    }
}
