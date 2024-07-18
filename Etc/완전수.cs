using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob9506
{
    internal class 완전수
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int input = int.Parse(Console.ReadLine());
                if (input == -1)
                    break;

                int calculate = 0;
                Queue<int> ints = new Queue<int>();
                string result = "";
                for(int i = 1; i < input; i++) 
                {
                    if (input % i == 0)
                    {
                        calculate += i;
                        ints.Enqueue(i);
                    }
                }
                if (calculate == input)
                {
                    int count = ints.Count;
                    for(int i = 0; i < count; i++)
                    {
                        if(ints.Count == 1)
                            result += ints.Dequeue();
                        else
                            result += ints.Dequeue() + " + ";
                    }
                    Console.WriteLine(input + " = " + result);
                }
                else
                    Console.WriteLine(input + " is NOT perfect.");
            }
        }

    }
}
