using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1406
{
    internal class 에디터
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> push = new Stack<char>();
            Stack<char> pop = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                push.Push(input[i]);
            }
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i < count; i++) 
            {
                string command = Console.ReadLine();
                switch(command[0]) 
                {
                    case 'L':
                        if (push.Count == 0)
                            break;
                        pop.Push(push.Pop());
                        break;
                    case 'D':
                        if (pop.Count == 0)
                            break;
                        push.Push(pop.Pop());
                        break;
                    case 'B':
                        if (push.Count == 0)
                            break;
                        push.Pop();
                        break;
                    case 'P':
                        push.Push(command[2]);
                        break;
                }
            }

            StringBuilder sb = new StringBuilder();
            Stack<char> stack = new Stack<char>();

            int n = push.Count;
            for (int i = 0; i < n; i++) 
            {
                stack.Push(push.Pop());
            }

            n = stack.Count;
            for(int i = 0; i < n; i++)
            {
                sb.Append(stack.Pop());
            }

            n = pop.Count;
            for (int i = 0; i < n; i++)
            {
                sb.Append(pop.Pop());
            }

            Console.WriteLine(sb);
        }
    }
}
