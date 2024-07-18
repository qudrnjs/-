using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2581
{
    internal class 소수
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            에라토스테네스의체(m, n);
        }

        /// <summary>
        /// 소수 본인을 제외한 배수를 전부 제거해 소수만 남게하는 공식
        /// </summary>
        /// <param name="m">최소 숫자</param>
        /// <param name="n">최대 숫자</param>
        /// <returns></returns>
        static void 에라토스테네스의체(int m, int n)
        {
            // 값 계산
            int result = 0;
            int minSosu = 0;

            // 주어진 숫자만큼 배열크기를 만든다 
            // 소수면 false값을 가질것이고 아니면 true값을 가질것이다.
            bool[] sosu = new bool[n + 1];
            sosu[0] = true;
            sosu[1] = true;

            // 2의 배수부터 차근차근 계산(소수 본인을 제외한)
            for (int i = 2 * 2; i < sosu.Length; i += 2)
                sosu[i] = true;

            // 그 이후 지워지지 않은 수의 배수들을 제거
            for (int j = 3; j < sosu.Length; j++)
            {
                // 만약 현재수가 지워지지 않은 수라면?
                if (sosu[j] == false)
                {
                    for (int i = j * 2; i < sosu.Length; i += j)
                    {
                        if (sosu[i] == false)
                            sosu[i] = true;
                    }
                }
            }

            // 현재 문제 계산...
            for (int i = m; i < sosu.Length; i++)
            {
                if (sosu[i] == false)
                {
                    if(minSosu == 0)
                    {
                        minSosu = i;
                    }
                    result += i;
                }
            }

            if (result != 0)
            {
                Console.WriteLine(result);
                Console.WriteLine(minSosu);
            }
            else
                Console.WriteLine(-1);
        }
    }
}
