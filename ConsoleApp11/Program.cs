using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //класс
            MyClass myClass = new MyClass();
            //структура
            MyStruct myStruct = new MyStruct();
            myClass.change = "не изм.";
            myStruct.change = "не изм.";
            Console.WriteLine("До вызова метода");
            Console.WriteLine($"MyClass.change={myClass.change}");
            Console.WriteLine($"MyStruct.change={myStruct.change}");
            //вызываем методы
            ClassTaker(myStruct);
            StructTaker(myStruct);
            Console.Read();
        }
        /// <summary>
        /// в этом методе пояснение что метод принимает объект класса и изменяет значение поле change
        /// </summary>
        /// <param name="myClass">myClass</param>
        static void ClassTaker(MyClass myClass)
        {

            myClass.change = "изм."; 
        }
        static void StructTaker (MyStruct myStruct)
        {
            myStruct.change = "изм.";
        }
    }
}
