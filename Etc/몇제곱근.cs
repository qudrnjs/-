using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculator
{
    internal class 몇제곱근
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(SquareCalculator(num));
        }

        static int SquareCalculator(int num)
        {
            int square = 0;
            while (num > 1)
            {
                num >>= 1;
                square++;
            }
            return square;
        }
    }
}
