using System;

namespace Prob11005
{
    internal class 진법변환2
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int num = int.Parse(input[0]);
            int formation = int.Parse(input[1]);
            Console.WriteLine(DecimalToBaseFormation(num, formation));
        }
       
        /// <summary>
        /// formation진수로 변환하는 메서드
        /// </summary>
        /// <param name="num">변환할 정수형변수</param>
        /// <param name="formation">진수</param>
        /// <returns></returns>
        static string DecimalToBaseFormation(int num, int formation)
        {
            // 결과 값을 넣을 변수생성
            string result = "";
            while(num > 0)
            {
                // formation나눈값의 나머지값을 할당
                int remain = num % formation;
                // 만약 10이상의 숫자이면(Char형태의 숫자문자열로 나타내지못함 따라서 알파벳으로 나타냄)
                if (remain > 9)
                    result += (char)(remain + 55);
                // 만약 10 미만이라면(Char형태의 숫자문자열로 나타낼수있음)
                else
                    result += (char)(remain + 48);
                num /= formation;
            }
            char[] charArray = result.ToCharArray();
            Array.Reverse(charArray);
            string formationNum = new string(charArray);
            return formationNum;
        }
    }
}
