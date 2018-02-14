using SeasonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplaySeason
{
    class Program
    {
        static void Main(string[] args)
        {
             SeasonLibrary.Season season = new SeasonLibrary.Season();
            Console.WriteLine(season.LateWinter);
            Console.ReadKey();
        }
    } 
}
