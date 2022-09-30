using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Computer
    {
        private string _name;
        private string _sizeRAM;
        private string _sizeHDD;
        private string _OS;

        public Computer(string name, string sizeRAM, string sizeHDD, string operSis)
        {
            _name = name;
            _sizeRAM = sizeRAM;
            _sizeHDD = sizeHDD;
            _OS = operSis;
        }

        public void TurnOn()
        {

        }

        public void InstallOS()
        {

        }

        public void TurnOff()
        {

        }

        public void GetInfo()
        {

        }
    }
}
