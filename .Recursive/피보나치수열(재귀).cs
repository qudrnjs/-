using System;

class 피보나치수열
{
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        // 피보나치 수열은 앞 두항의 합이 현재의 항이 값이 되는것
        // 예를 들어 5를 입력받았을 경우
        // 4번째 항이랑 3번째항을 더했을 경우 5번째 항이되는것
        // 즉 이것을 아래식 처럼 구할경우 매게 변수로 넘겨받고 리턴 받은값들은 현재항의 값이 되기에
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"피보나치 수열의 {n}번째 항: {Fibonacci(n)}");
    }
}
