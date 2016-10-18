using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommandPattern;

namespace DesignPatternTest
{
    [TestClass]
    public class CommandTest
    {
        [TestMethod]
        public void Light_On_Command_Test()
        {

            //receiver
            Light light = new Light();
            LightOnCommand lightOnCommand = new LightOnCommand(light);
            CommandInvoker invoker = new CommandInvoker();
            invoker.SetCommand(lightOnCommand);
            invoker.CommandOn();



        }

        public void Doctor_Advice_Make()
        {
            Doctor doctor = new Doctor();
            DoctorMakeAdvice doctorMakeAdvice = new DoctorMakeAdvice(doctor);

            CommandInvoker invoker = new CommandInvoker();
            invoker.SetCommand(doctorMakeAdvice);

            invoker.CommandOn();
        }


        public void MutiCommand_Execute()
        {
            Doctor doctor = new Doctor();
            DoctorMakeAdvice doctorMakeAdvice = new DoctorMakeAdvice(doctor);

            Light light = new Light();
            LightOnCommand lightOnCommand = new LightOnCommand(light);

            MultiCommand multiCommand = new MultiCommand(new ICommand[] { doctorMakeAdvice, lightOnCommand });

            multiCommand.Execute();

        }
    }
}
