using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Doctor
    {
        public void MakeAdvice()
        {
            Console.WriteLine("Doctor Make an advice");
        }

        public void UndoAdvice()
        {
            Console.WriteLine("Doctor Undo an advice");
        }
    }
}
