using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkClasses;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Person person = new Person("Dias", "Urinbasarov", "Kazakh", 18, 70);
            Console.WriteLine(Method.GetParametres(person));

            //2
            Console.WriteLine("\nЧисловая константа:{0}\nСтроковая константа: {1}", Constant.PHONE_NUMBER, Constant.INITIALS);

            Console.ReadLine();
        }
    }
}
