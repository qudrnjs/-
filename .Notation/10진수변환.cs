using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2745
{
    internal class 진법변환
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string num = input[0];
            int formation = int.Parse(input[1]);
            int result = Translate10(num, formation);
            Console.WriteLine(result);
        }

        static int Translate10(string num, int formation)
        {
            // 결과 값을 담을 변수를 미리생성한다.
            int result = 0;
            // 문자열 하나하나 계산
            for (int i = 0; i < num.Length; i++)
            {
                // 문자열 끝쪽부터 차례로(i = 1의자리부터i번째 문자열)
                char formNum = num[num.Length - 1 - i];
                // 현재 문자가 만약 숫자열이면
                if (Char.IsDigit(formNum))
                    result += (formNum - 48) * (int)Math.Pow(formation, i);
                // 현재 문자가 만약 문자열이면
                else
                    result += (formNum - 55) * (int)Math.Pow(formation, i);
            }
            return result;
        }
    }
}
