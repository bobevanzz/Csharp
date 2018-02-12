using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise
{
    class Class1
    {
        static void Main(string[] args)
        {
            Stack mystack = new Stack();

            Hashtable products = new Hashtable();
            products.Add("A100", 1000);
            products.Add("A200", 50);
            products.Add("B123", 123);
            products.Add("Z100-Red-large-oversize", 12);

            Console.WriteLine((int)products["A200"] * 2);
            Console.ReadLine();
            //int total = 6;

            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine(" Enter a number: ");
            //    string theString = Console.ReadLine();
            //    total = total + int.Parse(theString);
            //}
            //Console.WriteLine(total);
            //Console.ReadLine();
        }
    }
    }

