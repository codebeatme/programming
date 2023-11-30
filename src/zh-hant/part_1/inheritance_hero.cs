/*
本節文章
https://learnscript.net/zh-hant/programming/part-1/class-inheritance-base-and-derived-classes/ 什麽是類別的繼承，基礎類別，衍生類別
*/

// 一個表示英雄的類別
class Hero : Unit
{
    /// 欄位，英雄技能
    public string Skill;

    /// 建構方法
    public Hero(string name, int hp, int ap, string skill)
        // 呼叫基礎類別的建構方法
        : base(name, "英雄", hp, ap)
    {
        // 為 Hero 增加的欄位指派
        Skill = skill;
    }

    /// 方法 UseSkill
    public void UseSkill()
    {
        Console.WriteLine($"英雄 {Name} 使用了技能 {Skill}");
    }
}

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

/// 建立 Unit 和 Hero 的執行個體
Unit unit = new("史萊姆", "敵人", 10, 1);
Hero hero = new(
    "大花", 100, 10,
    "勝利狂歡"
    );

/// 呼叫執行個體的 Hurt 方法，讓他們互相傷害
// 英雄受到史萊姆的傷害
hero.Hurt(unit.Ap);
// 史萊姆受到英雄的傷害，史萊姆將陣亡
unit.Hurt(hero.Ap);

/// 英雄使用技能
hero.UseSkill();
*/