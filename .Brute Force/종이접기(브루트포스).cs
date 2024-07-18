using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos6_6
{
    // 브루트포스 알고리즘
    // 종이를 접었을때 만나는 숫자의 합이 가장큰 값
    internal class 종이접기
    {
        static void Main(string[] args)
        {
            int[,] grid = { { 1, 4, 16, 1 }, { 20, 5, 15, 8 }, { 6, 13, 36, 14 }, { 20, 7, 19, 15 } };
            int ret = solution(grid);

            Console.WriteLine(ret);
        }

        static int solution(int[,] grid) 
        {
            int answer = 0;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    // k 에 2씩더하는이유는 어떻게 접든간에 +1한다음 부터는 짝수만큼만 만날수있기때문에
                    for (int k = j + 1; k < 4; k += 2)
                        // max 이후에 첫번째는 가로로 접었을때 두번째는 세로로 접었을때
                        answer = Math.Max(answer, Math.Max(grid[i,j] + grid[j,k], grid[i,j] + grid[k,j]));
            return answer;
        }
    }
}
