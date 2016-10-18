using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{

    /// <summary>
    /// 命令模式命令接口对象
    /// </summary>
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
