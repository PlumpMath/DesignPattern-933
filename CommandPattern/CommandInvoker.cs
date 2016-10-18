using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CommandInvoker
    {
        public ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }


        public void CommandOn()
        {
            command.Execute();
        }


        public void CommandOff()
        {
            command.Undo();
        }

    }
}
