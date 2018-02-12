using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 65; i< 92; i++) 
            {
                char c = Convert.ToChar(i);
                Console.WriteLine((char)(i));
             }
            Console.ReadLine();
        }
    }
   // int CharToInt(char c)


}
