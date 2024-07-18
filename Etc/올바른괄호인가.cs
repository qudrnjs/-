using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob9012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string input = Console.ReadLine();
                bool able = true;
                Stack<int> stack = new Stack<int>();
                for (int j = 0; j < input.Length; j++)
                {
                    switch (input[j])
                    {
                        case '(': stack.Push(0); break;
                        case ')':
                            if (stack.Count == 0)
                            {
                                able = false;
                                break;
                            }
                            stack.Pop();
                            break;
                    }
                    if (able == false)
                    {
                        break;
                    }
                }
                if (stack.Count > 0)
                {
                    able = false;
                    Able(able);
                }
                else
                {
                    Able(able);
                }
            }
        }
        static void Able(bool a)
        {
            Console.WriteLine(a == true ? "YES" : "NO");
        }
    }
}