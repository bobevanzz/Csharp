using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbeginning
{ //
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Length");
            decimal lengthSide = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the Width");
            decimal widthSide = decimal.Parse(Console.ReadLine());

            decimal area = lengthSide * widthSide;
            Console.WriteLine("The area is: {0}", area);
            Console.ReadLine();
        }
    }
}
