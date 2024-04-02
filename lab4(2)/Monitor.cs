using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab4_2_
{
    internal class ComputerMonitor : ComputerComponent
    {
        public override string ToString()
        {
            return $"{Name} {Component}";
        }
    }
}