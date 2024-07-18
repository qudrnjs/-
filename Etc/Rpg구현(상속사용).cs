using System;
using System.Collections.Generic;

public class Unit
{
    public int HP;

    public Unit()
    {
        this.HP = 1000;
    }

    public virtual void under_attack(int damage)
    {
        // 아무 동작도 하지 않음
    }
}

public class Monster : Unit
{
    public int AttackPoint;

    public Monster(int attackPoint)
    {
        this.AttackPoint = attackPoint;
    }

    public override void under_attack(int damage)
    {
        this.HP -= damage;
    }

    public int attack()
    {
        return AttackPoint;
    }
}

public class Warrior : Unit
{
    public int AttackPoint;

    public Warrior(int attackPoint)
    {
        this.AttackPoint = attackPoint;
    }

    public override void under_attack(int damage)
    {
        this.HP -= damage;
    }

    public int attack()
    {
        return AttackPoint;
    }
}

public class Healer : Unit
{
    public int HealingPoint;

    public Healer(int healingPoint)
    {
        this.HealingPoint = healingPoint;
    }

    public override void under_attack(int damage)
    {
        this.HP -= damage;
    }

    public void healing(Unit unit)
    {
        unit.HP += HealingPoint;
    }
}

public class Program
{
    public static List<int> Solution(int monsterAttackPoint, int warriorAttackPoint, int healingPoint)
    {
        Monster monster = new Monster(monsterAttackPoint);
        Warrior warrior = new Warrior(warriorAttackPoint);
        Healer healer = new Healer(healingPoint);

        // 전사가 몬스터를 한 번 공격
        monster.under_attack(warrior.attack());
        // 몬스터가 전사를 한 번 공격
        warrior.under_attack(monster.attack());
        // 몬스터가 힐러를 한 번 공격
        healer.under_attack(monster.attack());
        // 힐러가 전사의 체력을 한 번 회복
        healer.healing(warrior);
        // 힐러가 몬스터의 체력을 한 번 회복
        healer.healing(monster);

        List<int> answer = new List<int> { monster.HP, warrior.HP, healer.HP };
        return answer;
    }

    public static void Main(string[] args)
    {
        int monsterAttackPoint = 100;
        int warriorAttackPoint = 90;
        int healingPoint = 30;

        List<int> ret = Solution(monsterAttackPoint, warriorAttackPoint, healingPoint);

        Console.Write("solution 함수의 반환 값은 {");
        for (int i = 0; i < ret.Count; i++)
        {
            if (i != 0)
                Console.Write(", ");
            Console.Write(ret[i]);
        }
        Console.WriteLine("} 입니다.");
    }
}
