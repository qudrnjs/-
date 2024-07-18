using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1037
{
    internal class 약수
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] inputStrArr = Console.ReadLine().Split();

            Array.Sort(inputStrArr, (a, b) => int.Parse(a).CompareTo(int.Parse(b)));

            int result = int.Parse(inputStrArr[0]) * int.Parse(inputStrArr[N - 1]);
            Console.WriteLine(result);
        }
    }
}
