using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace 분수계산
{
    internal class 분수계산
    {
        static void Main(string[] args)
        {
            int[] result = solution(9, 2, 3, 6);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] solution(int denum1, int num1, int denum2, int num2)
        {
            var num3 = num1 * num2;
            var denum3 = denum1 * num2 + denum2 * num1;
            var gcd = getgcd(num3, denum3);
            num3 /= gcd;
            denum3 /= gcd;

            int[] answer = new int[] { denum3, num3 };
            return answer;
        }

        public static int getgcd(int n, int m)
        {
            //두 수 n, m 이 있을 때 어느 한 수가 0이 될 때 까지
            //gcd(m, n%m) 의 재귀함수 반복
            if (m == 0) 
                return n;
            else
                return getgcd(m, n % m);
        }
    }
}
