using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1260
{
    internal class DFS와BFS
    {
        static void Main(string[] args)
        {
            // n = 정점의 개수 (정점 = 목적지)
            // m = 간선의 개수 (정점을 잇는 선)
            // v = 시작 정점 번호
            string[] spl = Console.ReadLine().Split();
            int n = int.Parse(spl[0]);
            int m = int.Parse(spl[1]);
            int v = int.Parse(spl[2]);

            // 그래프
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            for(int i = 1; i <= n; i++)
            {
                graph[i] = new List<int>();
            }

            for(int i = 0; i < m; i++)
            {
                spl = Console.ReadLine().Split();
                int a = int.Parse(spl[0]);
                int b = int.Parse(spl[1]);

                // 갈 수 있는 방법 등록
                graph[a].Add(b);
                graph[b].Add(a);
            }

            // 정점 번호가 작은 것을 먼저 방문하기 위해
            // 각 정점 번호의 순서를 정렬해 준다.
            foreach(var key in graph.Keys)
                graph[key].Sort();

            DFSAndBFS(graph, v);
        }

        static void DFSAndBFS(Dictionary<int, List<int>> graph, int v)
        {
            bool[] dfsEnter = new bool[graph.Count + 1];
            bool[] bfsEnter = new bool[graph.Count + 1];
            // BFS국룰
            // 큐 선언 -> 큐에 시작점 넣기 -> 시작점 방문 표시
            // -> while돌리기(큐에 값이 존재하지 않을때까지) ->
            // 디큐하고 방문하지 않은 다음 위치 전부 큐에 집어넣기 ->
            // (반복) -> 큐에 값이 남지 않으면 종료
            Queue<int> bfs = new Queue<int>();

            bfsEnter[v] = true;
            bfs.Enqueue(v);
            DFS(graph, v, dfsEnter);            
            Console.WriteLine();
            BFS(graph, bfs, bfsEnter);
            Console.WriteLine();

        }

        static void DFS(Dictionary<int, List<int>> graph, int cur, bool[] enter)
        {
            enter[cur] = true;
            Console.Write(cur + " ");

            foreach(var i in graph[cur])
            {
                if (!enter[i])
                {
                    DFS(graph, i, enter);
                }
            }
        }

        static void BFS(Dictionary<int, List<int>> graph, Queue<int> bfs, bool[] enter)
        {
            while(bfs.Count > 0) 
            {
                int cur = bfs.Dequeue();
                Console.Write(cur + " ");

                foreach(int i in graph[cur])
                {
                    if (!enter[i])
                    {
                        enter[i] = true;
                        bfs.Enqueue(i);
                    }
                }
            }
        }
    }
}
