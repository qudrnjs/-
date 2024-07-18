using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos6_5
{
    // 4X4보드판에서 오른쪽 또는 아래쪽으로만 갔을때 얻을수있는 최대 코인량
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] board = { { 6, 7, 1, 2 }, { 3, 5, 3, 9 }, { 6, 4, 5, 2 }, { 7, 3, 2, 6 } };
            int ret = solution(board);

            Console.WriteLine(ret);
        }

        // 브루트포스 알고리즘
        /// <summary>
        /// 행과 열 각자 인덱스가 0인곳을 전부 더해서 값을구한다음
        /// 행과열 둘중에 0이 아닌곳들은 왼쪽,위 중에서 더큰수를 찾아 더한다음
        /// 마지막 자리까지 이동하는 알고리즘
        /// </summary>
        /// <param name="board">보드판</param>
        /// <returns></returns>
        static int solution(int[,] board) 
        {
            int answer = 0;

            int[,] coins = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    // 만약 포지션이 0, 0이면
                    if (i == 0 && j == 0)
                        coins[i,j] = board[i,j];
                    // 만약 포지션이 0, n 이면
                    else if (i == 0 && j != 0)
                        coins[i,j] = board[i,j] + coins[i,j - 1];
                    // 만약 포지션이 n, 0 이면
                    else if (i != 0 && j == 0)
                        coins[i,j] = board[i,j] + coins[i - 1,j];
                    // 만약 포지션이 n, n 이면
                    else
                        coins[i,j] = board[i,j] + Math.Max(coins[i - 1,j], coins[i,j - 1]);
                }
            }

            answer = coins[3,3];
            return answer;
        }
    }
}
