using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob17425
{
    internal class 약수의합
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            // 최대 가능한 수만큼 크기 열어놓기
            long[] all = new long[100_0001];
            // 현재 약수들의 배수일경우에는 반드시 약수로 포함되기에
            // 1부터 최대 숫자까지 약수들을 모두 더해 구비해놓는다.(에라토스테네스의 체랑 같은 개념)
            // i = 현재 약수의 숫자
            for (int i = 1; i < all.Length; i++)
            {
                // j = i 약수의 배수
                for(int j = 1; i * j <= 100_0000;  j++)
                {
                    // i(약수)의 배수에 i(약수) 값을 미리 합산해놓는다.
                    all[i * j] += i;
                }
                // 우리가 원하는 값은 입력받은 숫자보다 같거나 작은 모든 자연수들의
                // 약수의 합이기에 각 인덱스에 이전 자연수들의 약수의 합을 합산한다.
                // 예 : 자연수 1의 경우 약수의 합이 1
                // 자연수 2의 경우 약수의합이 3
                // 따라서 인덱스 2번의 경우는 4의 값이 들어간다.
                // * 만약 각 인덱스의 약수의 합만 구하고 싶으면 이 아래식을 제외하면 된다.
                all[i] += all[i - 1];
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < testCase; i++)
            {
                int n = int.Parse(Console.ReadLine());
                // 각 배열에 인덱스에 맞는값을 미리 할당해놓았기에
                // 불러오기만 하면 출력완료 
                sb.AppendLine(all[n].ToString());
            }
            Console.WriteLine(sb);
        }

    }
}
