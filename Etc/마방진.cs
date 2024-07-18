using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos4_4
{
    internal class 마방진
    {
        static void Main()
        {
            List<List<int>> matrix = new List<List<int>> {
            new List<int> { 16, 2, 3, 13 },
            new List<int> { 5, 11, 10, 0 },
            new List<int> { 9, 7, 6, 12 },
            new List<int> { 0, 14, 15, 1 }
        };
            List<int> ret = Solution(matrix);

            Console.Write("solution 함수의 반환 값은 {");
            for (int i = 0; i < ret.Count; i++)
            {
                if (i != 0)
                    Console.Write(", ");
                Console.Write(ret[i]);
            }
            Console.WriteLine("} 입니다.");
        }

        const int n = 4;

        static List<int> 없는숫자찾기(List<List<int>> matrix)
        {
            List<int> nums = new List<int>();
            bool[] exist = new bool[n * n + 1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] != 0)
                    {
                        exist[matrix[i][j]] = true;
                    }
                }
            }
            for (int i = 1; i <= n * n; i++)
            {
                if (!exist[i])
                {
                    nums.Add(i);
                }
            }
            return nums;
        }

        static List<Tuple<int, int>> 빈장소찾기(List<List<int>> matrix)
        {
            List<Tuple<int, int>> coords = new List<Tuple<int, int>>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        coords.Add(Tuple.Create(i, j));
                    }
                }
            }
            return coords;
        }

        static bool 마방진검사(List<List<int>> matrix)
        {
            int sum = 0;
            for (int i = 1; i <= n * n; i++)
            {
                sum += i;
            }
            sum = sum / n;
            for (int i = 0; i < n; i++)
            {
                int rowSum = 0;
                int colSum = 0;
                for (int j = 0; j < n; j++)
                {
                    rowSum += matrix[i][j];
                    colSum += matrix[j][i];
                }
                if (rowSum != sum || colSum != sum)
                {
                    return false;
                }
            }
            int mainDiagonalSum = 0;
            int skewDiagonalSum = 0;
            for (int i = 0; i < n; i++)
            {
                mainDiagonalSum += matrix[i][i];
                skewDiagonalSum += matrix[i][n - 1 - i];
            }
            if (mainDiagonalSum != sum || skewDiagonalSum != sum)
            {
                return false;
            }
            return true;
        }

        static List<int> Solution(List<List<int>> matrix)
        {
            List<int> answer = new List<int>();
            List<Tuple<int, int>> coords = 빈장소찾기(matrix);
            List<int> nums = 없는숫자찾기(matrix);

            matrix[coords[0].Item1][coords[0].Item2] = nums[0];
            matrix[coords[1].Item1][coords[1].Item2] = nums[1];
            if (마방진검사(matrix))
            {
                for (int i = 0; i <= 1; i++)
                {
                    answer.Add(coords[i].Item1 + 1);
                    answer.Add(coords[i].Item2 + 1);
                    answer.Add(nums[i]);
                }
            }
            else
            {
                matrix[coords[0].Item1][coords[0].Item2] = nums[1];
                matrix[coords[1].Item1][coords[1].Item2] = nums[0];
                for (int i = 0; i <= 1; i++)
                {
                    answer.Add(coords[1 - i].Item1 + 1);
                    answer.Add(coords[1 - i].Item2 + 1);
                    answer.Add(nums[i]);
                }
            }
            return answer;
        }
    }
}
