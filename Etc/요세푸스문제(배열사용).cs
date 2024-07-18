using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1158
{
    /// <summary>
    /// b번째 마다 수를 지워나가면서 지우는 알고리즘
    /// </summary>
    internal class 요세푸스문제
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            StringBuilder sb = new StringBuilder();
            sb.Append("<");
            // 두가지 방법
            // List를 사용하거나
            // 불리언 배열을 사용하거나
            bool[] circle = new bool[a + 1];
            int count = 0;
            int deleteCount = 0;
            while (true)
            {
                for (int i = 1; i <= a; i++)
                {
                    if (circle[i])
                        continue;

                    count++;
                    if (count == b)
                    {
                        circle[i] = true;
                        deleteCount++;
                        sb.Append(i);
                        if(deleteCount == a)
                        {
                            sb.Append(">");
                            Console.WriteLine(sb);
                            return;
                        }

                        sb.Append(", ");
                        count = 0;
                    }
                }
            }
        }
    }
}
