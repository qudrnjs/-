using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2903
{
    internal class 중앙이동알고리즘
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int b = 1 << count;
            Console.WriteLine(b);
            Console.WriteLine((b + 1) * (b + 1));
        }
    }
}
