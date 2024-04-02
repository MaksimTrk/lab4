using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_2_
{
    internal class PersonalComputer
    {
        
        private ComputerMonitor monitor;
        private SystemBlock systemBlock;
        private Mouse mouse;
        private Keyboard keyboard;

        public PersonalComputer(ComputerMonitor monitor, SystemBlock systemBlock, Mouse mouse, Keyboard keyboard)
        {
            this.monitor = monitor;
            this.systemBlock = systemBlock;
            this.mouse = mouse;
            this.keyboard = keyboard;
        }

        public void TurnOn()
        {
            Console.WriteLine("computer is turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("computer is turned off.");
        }

        public void ConnectComponents()
        {
            monitor.Connect();
            systemBlock.Connect();
            mouse.Connect();
            keyboard.Connect();
        }

        public void DisconnectComponents()
        {
            monitor.Disconnect();
            systemBlock.Disconnect();
            mouse.Disconnect();
            keyboard.Disconnect();
        }

        public override string ToString()
        {
            return $"Personal computer with: {monitor}, {systemBlock}, {mouse} and {keyboard}.";
        }
    }
}



