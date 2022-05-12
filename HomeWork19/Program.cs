using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            MyList<int> lst = new MyList<int>();

            lst.Add(1);

            lst.Add(2);


            lst.Add(3);
            lst.Add(4);
            lst.Add(5);
            lst.Add(6);
            lst.Add(7);
            lst.Add(8);
            lst.Add(9);

            lst.Insert(0, 10);

            

            lst.PrintListToConsole();
            Console.WriteLine("_____________________________________-");
            Console.WriteLine(lst.Capacity);
            Console.WriteLine("_____________________________________-");

            foreach(var elem in lst)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine("_____________________________________-");
            Console.WriteLine($"({lst})");

            Console.ReadKey();
        }
    }
}