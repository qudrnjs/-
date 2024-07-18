using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1926
{
    internal class 그림
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int length = int.Parse(input[0]);
            int width = int.Parse(input[1]);

            // 색칠된 부분을 담을 int[,] 배열을 생성
            int[,] paper = new int[length, width];
            for (int i = 0; i < length; i++)
            {
                string[] colored = Console.ReadLine().Split();
                for (int j = 0; j < colored.Length; j++)
                {
                    if (colored[j] == "1")
                        paper[i, j] = 1;
                }
            }

            // BFS
            // 색칠된 부분을 찾으면 그부분의 상하좌우를 확인해가며
            // 만약 상하좌우가 이미 방문 완료된 좌표면 그좌표는 제외한다.
            // 방문한 좌표가 아닐 경우 색칠된 부분이면 그 다음 상하좌우를 비교할 좌표점으로 큐에 저장해놓고
            // 현재 좌표의 상하좌우 확인이 끝나면 큐에 담아놓은 좌표를 디큐한 이후 그 좌표의 상하좌우를 확인한다.
            // 그걸 반복한다.
            Queue<int[]> queue = new Queue<int[]>();
            bool[,] enter = new bool[length, width];

            // 방문할 위치
            // 순서대로 상, 하, 좌, 우를 나타낸다.
            int[] dx = { 0, 0, -1, 1 }; // 열
            int[] dy = { 1, -1, 0, 0 }; // 행

            // 그림의 갯수
            int picCnt = 0;
            // 최대 넓이 변수
            int maxExt = 0;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    // 현재 좌표가 이미 방문한 위치가 아닐경우에만 실행
                    if (!enter[i, j])
                    {
                        // 먼저 방문했다고 표시
                        enter[i, j] = true;
                        // 만약 색칠되어 있는 부분일 경우
                        if (paper[i, j] == 1)
                        {
                            queue.Enqueue(new int[] { i, j });
                            picCnt++;
                            int extCnt = 1;

                            // 큐에 값이 남아있지 않을때까지 무한 반복
                            while (queue.Count != 0)
                            {
                                // 현재 위치를 큐에서 반환
                                int[] curPos = queue.Dequeue();
                                // 상하좌우 비교
                                for (int k = 0; k < 4; k++)
                                {
                                    // 더한 위치값이 0보다 아래거나 최대 길이보다 길면 건너뛴다.
                                    if (curPos[0] + dy[k] < 0 || curPos[0] + dy[k] >= length ||
                                        curPos[1] + dx[k] < 0 || curPos[1] + dx[k] >= width)
                                        continue;

                                    // 새로운 위치 정의
                                    int[] newPos = { curPos[0] + dy[k], curPos[1] + dx[k] };
                                    if (!enter[newPos[0], newPos[1]])
                                    {
                                        // 방문 표시
                                        enter[newPos[0], newPos[1]] = true;
                                        if (paper[newPos[0], newPos[1]] == 1)
                                        {
                                            extCnt++;
                                            queue.Enqueue(new int[] { newPos[0], newPos[1] });
                                        }
                                    }
                                }
                            }
                            if (extCnt > maxExt)
                                maxExt = extCnt;
                        }
                    }
                }
            }
            Console.WriteLine(picCnt);
            Console.WriteLine(maxExt);
        }
    }
}
