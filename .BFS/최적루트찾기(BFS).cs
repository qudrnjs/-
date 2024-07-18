using System;
using System.Collections.Generic;
using System.Linq;

namespace Prob1697
{
    internal class Prob1697
    {
        static void Main(string[] args)
        {
            // 수빈과 브라더 한테 갈수 있는 가장 빠른 시간을
            // 구하는 알고리즘
            // 이동은 +1 , -1, X2로 가능
            string[] arr = Console.ReadLine().Split();

            // 수빈의 위치
            int subin_Pos = int.Parse(arr[0]);
            // 동생의 위치
            int bro_Pos = int.Parse(arr[1]);

            // BFS 활용
            // 이동할수 있는 모든 경우의 수를 넣을 큐
            Queue<int> que = new Queue<int>();
            // 방문한 곳을 재방문 하지않기 위한 불리언 변수
            bool[] enter = new bool[100_001];
            // 초기값 true는 BFS에서 필수
            enter[subin_Pos] = true;
            // 현재 수빈이의 위치를 처음으로 계산할 경우의 수로 집어넣고
            que.Enqueue(subin_Pos);
            // 시간을 계산할 변수
            int cnt = 0;

            while(true)
            {
                // cnt 만큼 시간이 지났을때 모든 경우의 수
                int frequency = que.Count();
                // 경우의 수 전부 계산
                for (int i = 0; i < frequency; i++)
                {
                    int cur_Pos = que.Dequeue();
                    // 만약 현재 수빈의 위치가 동생의 위치랑 같다면 결과값
                    if (cur_Pos == bro_Pos)
                    {
                        Console.WriteLine(cnt);
                        return;
                    }

                    // 경우의 수에 부합하지 않은
                    // 위치는 제외하고 계산
                    if (cur_Pos + 1 <= bro_Pos && !enter[cur_Pos + 1])
                    {
                        que.Enqueue(cur_Pos + 1);
                        enter[cur_Pos + 1] = true;
                    }
                    if (cur_Pos - 1 >= 0 && !enter[cur_Pos - 1])
                    {
                        que.Enqueue(cur_Pos - 1);
                        enter[cur_Pos - 1] = true;
                    }
                    if (cur_Pos * 2 <= 100_000 && !enter[cur_Pos * 2])
                    {
                        que.Enqueue(cur_Pos * 2);
                        enter[cur_Pos * 2] = true;
                    }
                }
                // 최종적으로 시간이 지남을 표시
                cnt++;
            }
        }
    }
}
