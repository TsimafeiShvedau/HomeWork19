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
            MyList<int> lst = new MyList<int>(100);

            lst.Add(1);

            lst.Add(2);


            lst.Add(3);
            lst.Add(4);
            lst.Add(5);
            lst.Add(6);
            lst.Add(7);
            lst.Add(8);
                lst.Add(9);

            lst.Insert(0, 8);

            lst.Remove(1);

            lst.PrintListToConsole();
            //int[] array = new int[5];
            //lst.CopyTo(array, 0);
            Console.WriteLine("_____________________________________-");
            Console.WriteLine(lst.Capacity);
            lst.Clear();
            Console.WriteLine(lst.Capacity);



            Console.WriteLine("_____________________________________-");

            foreach(var elem in lst)
            {
                Console.WriteLine(elem);
            }


            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //Console.WriteLine(lst.IndexOf(25));

            List<int> vs = new List<int>();
            
            Console.ReadKey();
        }
    }
}