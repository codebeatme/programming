/*
本节文章
https://learnscript.net/zh/programming/part-1/class-inheritance-base-and-derived-classes/ 什么是类的继承，基类，派生类
*/

// 一个表示英雄的类
class Hero : Unit
{
    /// 字段，英雄技能
    public string Skill;

    /// 构造方法
    public Hero(string name, int hp, int ap, string skill)
        // 调用基类的构造方法
        : base(name, "英雄", hp, ap)
    {
        // 为 Hero 新增的字段赋值
        Skill = skill;
    }

    /// 方法 UseSkill
    public void UseSkill()
    {
        Console.WriteLine($"英雄 {Name} 使用了技能 {Skill}");
    }
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