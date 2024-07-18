using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos4_6
{
    internal class 자아도취수
    {
        public static int Power(int baseValue, int exponent)
        {
            int val = 1;
            for (int i = 0; i < exponent; i++)
            {
                val *= baseValue;
            }
            return val;
        }

        public static List<int> Solution(int k)
        {
            List<int> answer = new List<int>();

            int range = Power(10, k);
            for (int i = range / 10; i < range; i++)
            {
                int current = i;
                int calculated = 0;
                while (current != 0)
                {
                    calculated += Power(current % 10, k);
                    current = current / 10;
                }
                if (calculated == i)
                    answer.Add(i);
            }
            return answer;
        }

        public static void Main()
        {
            int k = 3;
            List<int> ret = Solution(k);

            Console.Write("solution 함수의 반환 값은 { ");
            for (int i = 0; i < ret.Count; i++)
            {
                if (i != 0)
                    Console.Write(", ");
                Console.Write(ret[i]);
            }
            Console.WriteLine(" } 입니다.");
        }
    }
}
