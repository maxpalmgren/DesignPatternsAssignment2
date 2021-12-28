using Assignment2.StateCommandMemento.CommandClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.MachineClass
{
    class MachineStateOff : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Machine turned OFF");
        }

        public void Print(string text)
        {
            Console.WriteLine("Cant Print while Machine is OFF, text send to queue");
        }
    }
}
