using System;
using System.Text;
using System.Threading.Tasks;

namespace Prob6588
{
    internal class 골드바흐의추측
    {
        static void Main(string[] args)
        {
            // 하염없이 돌아온 에라토스테네스의 체 시간
            // false == 소수임
            // true == 소수아님
            bool[] sosu = new bool[100_0001];

            for (int i = 2 * 2; i < sosu.Length; i += 2)
                sosu[i] = true;

            for (int j = 3; j < sosu.Length; j++)
            {
                if (sosu[j] == false)
                {
                    for (int i = j * 2; i < sosu.Length; i += j)
                    {
                        if (sosu[i] == false)
                            sosu[i] = true;
                    }
                }
            }

            StringBuilder sb = new StringBuilder(); ;
            // 해답을 찾았는지 플래그변수           
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                bool findNum = false;

                // 0 입력시 종료
                if (n == 0)
                    break;
                int size = n / 2;
                // 홀수중 제일 작은 소수인 3부터시작한다.
                // 현재 입력받은 수의 절반까지만 계산(쓸데없는 계산시간 줄이는 용도)
                for(int i = 3; i <= size; i += 2)
                {
                    // 소수가 아닐경우 넘어간다.
                    // 예 : 9 는 소수가 아니기에 건너뜀
                    if (sosu[i] == true)
                        continue;

                    int cal = n - i;
                    if (sosu[cal] == false)
                    {
                        sb.AppendLine($"{n} = {i} + {cal}");
                        findNum = true;
                        break;
                    }
                }
                if (!findNum)
                {
                    sb.AppendLine("Goldbach's conjecture is wrong.");
                }
            }
            Console.Write(sb);
        }
    }
}
