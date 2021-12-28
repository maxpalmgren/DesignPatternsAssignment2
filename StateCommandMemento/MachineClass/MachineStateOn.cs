using Assignment2.StateCommandMemento.CommandClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.MachineClass
{
    class MachineStateOn : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Machine turned ON");
        }

        public void Print(string text)
        {
            Console.WriteLine(text);
            
        }
    }
}
