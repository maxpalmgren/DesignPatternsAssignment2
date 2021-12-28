﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.CommandClass
{
    public interface ICommand
    {
        public string Text { get; set; }
        public void Do();
    }
}
