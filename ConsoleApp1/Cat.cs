using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cat
    {
        private string _name;
        private string _color;
        private int _age;

        public Cat()
        {
            
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        

        public void GetInfo(Cat cat1)
        {
            
            if (_age < 2)
            {
                Console.WriteLine($"Имя вашего котёнка - {_name}");
                Console.WriteLine($"Цвет вашего котёнка - {_color}");
                Console.WriteLine($"Возвраст вашего котёнка - {_age}");
            }
            else
            {
                Console.WriteLine($"Имя вашего кота - {_name}");
                Console.WriteLine($"Цвет вашего кота - {_color}");
                Console.WriteLine($"Возвраст вашего кота - {_age}");
            }
        }

    }
}
