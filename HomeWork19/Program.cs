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
            MyList<int> somelist = new MyList<int>();
            
            somelist.Add(1);
            somelist.Add(2);
            somelist.Add(3);
            somelist.Add(4);
            somelist.Add(5);
            somelist.Add(6);
            somelist.Insert(2, 55);


            Console.WriteLine("-------------------------------");
            Console.WriteLine($"ToString: {somelist}");
            Console.WriteLine($"Count: {somelist.Count}");
            Console.WriteLine($"Capacity: {somelist.Capacity}");

            Console.ReadKey();
        }
    }
}