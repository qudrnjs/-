using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5086
{
    internal class 배수와약수
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string input = Console.ReadLine();
                if (input == "0 0")
                    break;
                string[] arrInput = input.Split();
                int a = int.Parse(arrInput[0]);
                int b = int.Parse(arrInput[1]);
                if (a > b)
                {
                    if(a % b == 0)
                        Console.WriteLine("multiple");
                    else
                        Console.WriteLine("neither");
                }
                else 
                {
                    if(b % a == 0)
                        Console.WriteLine("factor");
                    else
                        Console.WriteLine("neither");
                }
            }
        }
    }
}
