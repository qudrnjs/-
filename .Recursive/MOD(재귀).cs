using System;

namespace Prob1629
{
    internal class 곱셈
    {
        static void Main(string[] args)
        {
            string[] spl = Console.ReadLine().Split();
            long a = long.Parse(spl[0]);
            long b = long.Parse(spl[1]);
            long c = long.Parse(spl[2]);
            Console.WriteLine(Answer(a, b, c));
        }

        static long Answer(long a, long b, long c)
        {
            // a의 1승 까지 계산
            if (b == 1)
                return a % c;
            // a의 b승은 a의 2b(b / 2)의 성질과 같다는 점을 이용
            // 즉 현재 제곱을 반으로 나누어 계산후 그 값끼리 두번 곱하면
            // 현재 원하는 제곱의 값을 구할 수 있다는 공식
            // 따라서 절반만큼의 시간을 줄일수 있기에 시간 복잡도는 Big-O(log(b))
            // 예) a의 6승은 a의 3승 이후 a의 3승의 값을 한번 더 곱하면
            // a의 6승이 된다.
            long res = Answer(a, b / 2, c);
            res = res * res % c;
            // 짝수의 경우는 깔끔하게 2로 나누어져
            // 홀수랑 달리 제곱 하나가 사라지는 경우는 없기에 res를 반환
            if (b % 2 == 0)
                return res;
            // 그와 달리 홀수는 2로 나누면 b의 값이 하나 줄기에
            // a를 한번더 곱해주고 c로 나눈 나머지 값을 다시 가져온다.
            // 예) b = 3 -> b / 2 = 1 1소실 즉 원래 값을 구하기위해
            // a만 한번더 곱해주면 원래의 값이 나오기에 a를 한번 더 곱한다.
            return
                res * a % c;
        }
    }
}
