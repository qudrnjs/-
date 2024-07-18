using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2292
{
    internal class 벌집
    {
        static void Main(string[] args)
        {
            int roomNum = int.Parse(Console.ReadLine());
            int a = 0;
            int count = 0;
            for (int i = 1; i <= roomNum; i++)
            {
                int result = 6 * a;
                a += i;
                if (roomNum <= result + 1)
                {
                    count = i;
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}