using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos5_8
{
    internal class 공약수구하기
    {
        static void Main(string[] args)
        {
            int a = 24;
            int b = 9;
            int c = 15;
            int ret = solution(a, b, c);

            // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
            Console.WriteLine("solution 함수의 반환 값은 {0} 입니다.", ret);
        }

        static int solution(int a, int b, int c)
        {
            int answer = 0;

            int gcd = 최대공약수(최대공약수(a, b), c);
            answer = 갯수구하기(gcd);

            return answer;
        }

        static int 최대공약수(int a, int b)
        {
            int mod = a % b;

            while (mod > 0)
            {
                a = b;
                b = mod;
                mod = a % b;
            }

            return b;
        }

        static int 갯수구하기(int n)
        {
            int answer = 0;

            // 최대공약수의 약수들은 현재 모든 수의 약수가 될수있다.
            for (int i = 1; i <= n; i++)
            {
                if (약수(n, i))
                    answer++;
            }

            return answer;
        }

        static bool 약수(int p, int q)
        {
            if (p % q == 0)
                return true;
            else
                return false;
        }
    }
}
