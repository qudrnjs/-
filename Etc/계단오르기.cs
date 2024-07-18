using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3;
            int ret1 = solution(n1);

            // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
            Console.WriteLine("solution 함수의 반환 값은 {0} 입니다.", ret1);

            int n2 = 4;
            int ret2 = solution(n2);

            // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
            Console.WriteLine("solution 함수의 반환 값은 {0} 입니다.", ret2);
        }

        static int solution(int n)
        {
            int answer = 0;

            int[] steps = new int[n + 1];
            steps[1] = 1;
            steps[2] = 2;
            steps[3] = 4;
            // 각 단계의 1, 2, 3계단 씩 오르는 경우를 계산하기위해
            // 현재 계단의 -1, -2 , -3을 합해서 모든 경우의 수를계산한다.
            for (int i = 4; i <= n; i++)
                steps[i] = steps[i - 1] + steps[i - 2] + steps[i - 3];
            answer = steps[n];

            return answer;
        }
    }
}
