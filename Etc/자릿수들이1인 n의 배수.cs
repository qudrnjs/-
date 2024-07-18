using System;

namespace Prob4375
{
    internal class One
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == null || input == "")
                    break;

                int n = int.Parse(input);
                int one = 1 % n;
                int count = 1;
                while (one != 0)
                {
                    // 입력받은수 보다 크면 작게 초기화
                    // n의 나머지로 계산을하기에 차이가없음 
                    // 예: 9999 입력후 one변수가 9999를 넘었을때 1112로 변하지만 
                    // 9999의 배수계산을하는건 마찬가지기에
                    // 11111과 같은의미이다
                    one = (one * 10 + 1) % n;
                    count++;
                }
                Console.WriteLine(count);
            }
        }
    }
}
