using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class DoctorMakeAdvice : ICommand
    {
        private Doctor doctor;

        public DoctorMakeAdvice(Doctor doctor)
        {
            this.doctor = doctor;
        }



        public void Execute()
        {
            doctor.MakeAdvice();
        }

        public void Undo()
        {
            doctor.UndoAdvice();
        }
    }
}
