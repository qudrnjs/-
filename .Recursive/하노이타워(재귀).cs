using System;

class Program
{
    static void TowerOfHanoi(int n, char from_rod, char to_rod, char aux_rod)
    {
        if (n == 1)
        {
            Console.WriteLine($"원판 1을 {from_rod}에서 {to_rod}로 이동");
            return;
        }

        TowerOfHanoi(n - 1, from_rod, aux_rod, to_rod);
        Console.WriteLine($"원판 {n}을 {from_rod}에서 {to_rod}로 이동");
        TowerOfHanoi(n - 1, aux_rod, to_rod, from_rod);
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // 원판의수
        TowerOfHanoi(n, 'A', 'C', 'B');
    }
}
