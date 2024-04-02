using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_2_
{
    internal class Keyboard : ComputerComponent
    {
        public override string ToString()
        {
            return $"{Name} {Component}";
        }
    }
}
