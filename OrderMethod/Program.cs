using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OrderLunch(7));
            Console.WriteLine(OrderLunch(1, "Pizza", "Fries"));
            Console.WriteLine(OrderLunch(1,"pizza", "Coke"));
            Console.ReadLine();
        }

        private static string OrderLunch(int drink, string maindish, string sidedish)
        {
            string drinkText;
            switch (drink)
            {
                case 1: drinkText = "Coke"; break;
                case 2: drinkText = "Diet Coke"; break;
                case 3: drinkText = "Coffee"; break;
                default: drinkText = "Water"; break;
            }

            return "You ordered a " + drinkText + " and " + maindish + "with" + sidedish;
        }

        private static string OrderLunch( int drink, string maindish)
        {
            return OrderLunch(drink, maindish, "no side dish");
            //string maindishText;
            //switch (maindish)
            //{
            //    case 1: maindishText = "Pizza"; break;
            //    case 2: maindishText = "Pretzel"; break;
            //    case 3: maindishText = "eggs"; break;
            //    default: maindishText = "cheese sandwich";break;


            }
            return "You ordered a " + maindishText + "with" + drink;
        }

        private static string OrderLunch(int mealID)
        {
            string mealidtext;
            switch (mealID)
            {
                case 1: mealidtext="1"; break;
                case 2: mealidtext="2"; break;
                case 3: mealidtext="3"; break;
                default: mealidtext="1";break;
            }
            return "Your ordered a number " + mealidtext; 
        }
    }
}

               
