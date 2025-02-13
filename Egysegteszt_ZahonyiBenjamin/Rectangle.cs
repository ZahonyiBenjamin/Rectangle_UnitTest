using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egysegteszt_ZahonyiBenjamin
{
    public class Rectangle
    {
        public double CalculateArea(double width, double height)
        {
            if (width < 0 || height < 0)
            {
                throw new Exception();
            }

            return width * height;
        }
        static void Main(string[] args)
        {
            Console.Write("A téglalap egyik oldala: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("A téglalap másik oldala: ");
            double height = Convert.ToDouble(Console.ReadLine());
            var calculator = new Rectangle();

            Console.WriteLine($"A téglalap területe: {calculator.CalculateArea(width, height)}");


            Console.ReadKey();
        }
    }
}
