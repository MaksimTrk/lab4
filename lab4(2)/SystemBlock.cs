using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab4_2_
{
    internal class SystemBlock : ComputerComponent
    {
        public override string ToString()
        {
            return $"{Name} {Component}";
        }
    }
}
