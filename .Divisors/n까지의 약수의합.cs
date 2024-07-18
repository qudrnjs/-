using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob17427
{
    internal class 약수의합2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long total = 0;
            // n까지의수들 중에 각 숫자가 약수가 되는 갯수만큼 전부 더한다
            // 예 : n의 값으로 4를 입력한다.
            // 1 = 1,2,3,4 의약수로 포함되니    총 4개 +4
            // 2 = 2,4 의 약수로 포함되니       총 2개 +4
            // 3 = 3 의 약수로 포함되니         총 1개 +3
            // 4 = 4 의 약수로 포함되니         총 1개 +4
            // 답은 15
            // (n / i) = 약수의 갯수
            // * i  = 합산
            for (int i = 1; i <= n; i++)
            {
                total += (n / i) * i;
            }
            Console.WriteLine(total);
        }
    }
}
