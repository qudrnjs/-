using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2960
{
    internal class 에라토스테네스의체
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            bool[] sosu = new bool[n + 1];
            int count = 0;

            for (int j = 2; j < n + 1; j++)
            {
                if (j == 2)
                {
                    for (int i = j; i < n + 1; i += j)
                    {
                        sosu[i] = true;
                        count++;
                        if (count == k)
                        {
                            Console.WriteLine(i);
                            break;
                        }
                    }
                }
                else if (j % 2 == 1 && sosu[j] == false)
                {
                    for (int i = j; i < n + 1; i += j)
                    {
                        if (sosu[i] == false)
                        {
                            sosu[i] = true;
                            count++;
                        }
                        if (count == k)
                        {
                            Console.WriteLine(i);
                            break;
                        }
                    }
                }
            }
        }
    }
}
