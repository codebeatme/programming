/*
本节文章
https://learnscript.net/zh/programming/part-1/class-inheritance-base-and-derived-classes/ 什么是类的继承，基类，派生类
*/

// 一个表示游戏单位的类
class Unit
{
    /// 字段，单位名称，类别，生命值，攻击力，是否已阵亡
    public string Name;
    public string Type;
    public int Hp;
    public int Ap;
    public bool Dead = false;

    /// 构造方法
    public Unit(string name, string type, int hp, int ap)
    {
        Name = name;
        Type = type;
        Hp = hp;
        Ap = ap;
    }

    /// 方法 Hurt，让单位受到参数 ap 指定的伤害量，并返回一个布尔值，以表明单位受伤后是否已经阵亡
    public bool Hurt(int ap)
    {
        if (!Dead)
        {
            // 扣除单位生命值后，如果生命值小于 0，则让其阵亡
            Hp -= ap;
            Console.WriteLine($"{Name} 受到 {ap} 点伤害，生命值剩余 {Hp}");

            if (Hp <= 0)
            {
                // 字段 Dead 设为 true，表示单位已经阵亡
                Dead = true;
                Console.WriteLine($"{Name} 已经阵亡");
            }
        }

        return Dead;
    }

    ///
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 创建 Unit 和 Hero 的实例
Unit unit = new("史莱姆", "敌人", 10, 1);
Hero hero = new(
    "大花", 100, 10,
    "胜利狂欢"
    );

/// 调用实例的 Hurt 方法，让他们互相伤害
// 英雄受到史莱姆的伤害
hero.Hurt(unit.Ap);
// 史莱姆受到英雄的伤害，史莱姆将阵亡
unit.Hurt(hero.Ap);

/// 英雄使用技能
hero.UseSkill();
*/