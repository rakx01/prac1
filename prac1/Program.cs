using System;

namespace prac1
{
    class Monitor
    {
        public string Firm { get; set; }
        public string Type { get; set; }
        public float Diagonal { get; set; }

        public void print()
        {
            Console.WriteLine("Фирма:" + Firm + " " + "Тип:" + Type + " " + "Диагональ:" + Diagonal + " ");
        }

        public void vrite()
        {
            Console.WriteLine("Введите фирму: ");
            Firm = Console.ReadLine();
            Console.WriteLine("Введите тип: ");
            Type = Console.ReadLine();
            Console.WriteLine("Введите диагональ: ");
            Diagonal = int.Parse(Console.ReadLine());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Monitor name = new Monitor();
            name.vrite();
            name.print();
            Console.ReadKey();
        }
    }
}
