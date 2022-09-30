using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class RAM
    {
        private string _manufacturer;
        private int _sizeRAM;

        public RAM(string manufacturer, int sizeRAM)
        {
            _manufacturer = manufacturer;
            _sizeRAM = sizeRAM;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Количество Оперативной памяти - {_sizeRAM}");
        }
    }
}
