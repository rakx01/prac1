using System;
using System.Collections.Generic;
using System.Text;

namespace prac1
{
    class Monitor
    {

        public string Firm { get; set; }
        public string Type { get; set; }
        public float Diagonal { get; set; }
        public void Mon()
        {
            Console.WriteLine("Фирма:" + Firm + " " + "Тип:" + Type + " " + "Диагональ:" + Diagonal + " ");
        }

        public void Input()
        {
            Console.WriteLine("Введите фирму: ");
            Firm = Console.ReadLine();
            Console.WriteLine("Введите тип: ");
            Type = Console.ReadLine();
            Console.WriteLine("Введите диагональ: ");
            Diagonal = int.Parse(Console.ReadLine());
        }
    }
}