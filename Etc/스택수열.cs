using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1874
{
    // 개선판
    internal class 스택수열
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            Stack<int> stack = new Stack<int>();
            int num = 0;
            for(int i = 0; i < n; i++) 
            {
                int requireNum = int.Parse(Console.ReadLine());

                for (int j = num; j < requireNum; j++)
                {
                    stack.Push(++num);
                    sb.AppendLine("+");
                }

                if (stack.Peek() == requireNum)
                {
                    stack.Pop();
                    sb.AppendLine("-");
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }                             
            }
            Console.WriteLine(sb);
        }
    }
}
