using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class 기사단원의무기
    {
        static void Main(string[] args)
        {
            int number = 5;
            int limit = 3;
            int power = 2;
            
            int answer = 0;
            int[] divisorCount = new int[number + 1];
            for (int i = 1; i <= number; i++)
            {
                // 해당 i의 약수를 가지는 숫자에 카운트를 더해 
                // 약수의 갯수를 미리 구해놓는다.
                for (int j = i; j <= number; j += i)
                {
                    divisorCount[j]++;
                }
            }

            for (int i = 1; i <= number; i++)
            {
                if (divisorCount[i] > limit)
                    divisorCount[i] = power;
                answer += divisorCount[i];
            }
            Console.WriteLine(answer);
        }
    }
}
