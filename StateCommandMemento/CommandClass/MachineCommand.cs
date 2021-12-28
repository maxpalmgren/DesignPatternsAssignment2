using Assignment2.StateCommandMemento.MachineClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.CommandClass
{
    class MachineCommand : ICommand
    {
        public string Text { get; set; }
        public Machine Machine { get; set; }

        public MachineCommand(Machine machine, string inputText)
        {
            Machine = machine;
            Text = inputText;
        }

        public void Do()
        {
            Machine.Print(Text);
        }
    }
}
