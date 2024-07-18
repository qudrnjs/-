using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int[,] connections = { { 1, 2 }, { 1, 3 }, { 2, 3 } };
            int ret = solution(n, connections);

            // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
            Console.WriteLine("solution 함수의 반환 값은 {0} 입니다.", ret);
        }

        static int solution(int n, int[,] connections)
        {
            int answer = 0;

            int[] parent = new int[n + 1];
            for (int i = 1; i <= n; i++)
                parent[i] = i;

            for (int i = 0; i < connections.Length; i++)
            {
                if (merge(ref parent, connections[i, 0], connections[i, 1]))
                {
                    answer = i + 1;
                    break;
                }
            }

            return answer;
        }

        static int find(ref int[] parent, int u)
        {
            if (u == parent[u])
                return u;

            parent[u] = find(ref parent, parent[u]);
            return parent[u];
        }

        static bool merge(ref int[] parent, int u, int v)
        {
            u = find(ref parent, u);
            v = find(ref parent, v);

            if (u == v)
                return true;

            parent[u] = v;
            return false;
        }
    }
}
