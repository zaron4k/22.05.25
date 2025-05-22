using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook temp = new Notebook();
            temp.model = "Ultra";
            temp.proizv = "Noname";
            temp.price = 20000;
            Console.WriteLine($"Модель:{temp.model}\tПроизводитель:{temp.proizv}\tЦена:{temp.price}");
            Console.Read();
        }
    }
}
