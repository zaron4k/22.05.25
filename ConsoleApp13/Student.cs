using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// описать структуру с полями ФИО, группа, информатика, физика, история. создать массив или колекцию из n объектов данной структуры.
///ввод данных осуществлять с клавиатуры сведение об объектах вывести в табличном видею в случае отсутствие информании об объект вывести информацию об осутсвие объекта.
 ///определить средний бал оценок по предмету. вывести студентов общий бал который выше 4 и подсчитать их колличество.
/// </summary>
class Student
{
    struct Students
    {
        public string FIO;
        public string Group;
        public int Informatics;
        public int Physics;
        public int History;
        public int SRB;
    }
    public void info(string FIO, string Group, int Informatics, int Physics, int History, int SRB)
    {
        Console.WriteLine($"ФИО:{FIO}");
        Console.WriteLine($"Оценка по физики:{Physics}");
        Console.WriteLine($"Оценка по истории:{History}");
        Console.WriteLine($"Оценка по информатике:{Informatics}");
        Console.WriteLine($"Средний балл:{SRB}");
    }
   
}
