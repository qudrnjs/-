using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob14215
{
    internal class 세막대
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            int max = 0;
            int result = 0;
            if (a > b && a > c)
            {
                max = a;
                result = b + c;
            }
            else if (b > a && b > c)
            {
                max = b;
                result = a + c;
            }
            else
            {
                max = c;
                result = a + b;
            }

            if(max >= result)
                Console.WriteLine(result + result -1);
            else
                Console.WriteLine(max + result);
        }
    }
}
