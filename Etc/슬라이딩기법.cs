using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos3_9
{
    internal class Program
    {
        public static int solution(List<int> revenue, int k)
        {
            int answer = 0;
            int n = revenue.Count;
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += revenue[i];
            }
            answer = sum;
            for (int i = k; i < n; i++)
            {
                // 슬라이딩 기법
                // 이전에 나왔던 합과 전에 나왔던 왼쪽끝을 빼주고 오른쪽 새로운값을 더해준다.
                sum = sum - revenue[i - k] + revenue[i]; 
                if (answer < sum)
                    answer = sum;
            }
            return answer;
        }

        static void Main(string[] args)
        {
            List<int> revenue1 = new List<int> { 1, 1, 9, 3, 7, 6, 5, 10 };
            int k1 = 4;
            int ret1 = solution(revenue1, k1);

            // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
            Console.WriteLine("solution 함수의 반환 값은 " + ret1 + " 입니다.");

            List<int> revenue2 = new List<int> { 1, 1, 5, 1, 1 };
            int k2 = 1;
            int ret2 = solution(revenue2, k2);

            // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
            Console.WriteLine("solution 함수의 반환 값은 " + ret2 + " 입니다.");
        }
    }
}
