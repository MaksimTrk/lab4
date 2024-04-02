using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_2_
{
    internal class ComputerComponent
    {
        public string Name { get; set; }
        public string Component {  get; set; }
        public void Connect()
        {
            Console.WriteLine($"{Component} connected.");
        }

        public void Disconnect()
        {
            Console.WriteLine($"{Component} disconnected.");
        }
    }
}
