using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegularPolygonLib;

namespace RegularPolygonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RegularPolygonAreaCalcFactory myFactory = new RegularPolygonAreaCalcFactory();

            IRegularPolygonAreaCalc regularPolygonAreaCalc = myFactory.GetRegularPolygonAreaCalc();

            if (args.Length == 2)
            {
                double n = 0, sideLength = 0;
                if (!double.TryParse(args[0], out n) || !double.TryParse(args[1], out sideLength))
                {
                    Console.WriteLine("Wrong input. Sorry, cannot calculate the regular polygon area for you.");
                }
                else
                {
                    double.TryParse(args[0], out n);
                    double.TryParse(args[1], out sideLength);
                    double result = regularPolygonAreaCalc.CalculateArea(n, sideLength);
                    Console.WriteLine("Regular polygon with " + n + "sides of " + sideLength + " length equals " + result);
                    Console.ReadKey();
                }
            }
            else
            {
                string s = "";
                int n = 0;
                double sideLength = 0;
                do
                {
                    Console.WriteLine("Regular polygon area calculation. For correct result insert correct number n of vertices (integer and n > 2): ");
                    s = Console.ReadLine();
                } while (!int.TryParse(s, out n));
                do
                {
                    Console.WriteLine("Insert correct side lenght: ");
                    s = Console.ReadLine();
                } while (!double.TryParse(s, out sideLength));
                double result = regularPolygonAreaCalc.CalculateArea(n, sideLength);
                Console.WriteLine("Regular polygon with " + n + "sides of " + sideLength + " length equals " + result);
                Console.ReadKey();
            }


        }
    }
}
