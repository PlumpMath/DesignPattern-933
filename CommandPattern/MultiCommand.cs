using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{

    //多命令实现
    public class MultiCommand : ICommand
    {
        public ICommand[] commands;

        public MultiCommand(ICommand[] commands)
        {
            this.commands = commands;
        }



        public void Execute()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in commands)
            {
                command.Undo();
            }
        }
    }
}
