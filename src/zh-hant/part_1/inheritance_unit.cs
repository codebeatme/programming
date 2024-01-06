/*
本節文章
https://learnscript.net/zh-hant/programming/part-1/class-inheritance-base-and-derived-classes/ 什麽是類別的繼承，基礎類別，衍生類別
*/

// 一個表示遊戲單位的類別
class Unit
{
    /// 欄位，單位名稱，類別，生命值，攻擊力，是否已陣亡
    public string Name;
    public string Type;
    public int Hp;
    public int Ap;
    public bool Dead = false;

    /// 建構方法
    public Unit(string name, string type, int hp, int ap)
    {
        Name = name;
        Type = type;
        Hp = hp;
        Ap = ap;
    }

    /// 方法 Hurt，讓單位受到參數 ap 指定的傷害量，並傳回一個布林值，以表明單位受傷後是否已經陣亡
    public bool Hurt(int ap)
    {
        if (!Dead)
        {
            // 扣除單位生命值後，如果生命值小於 0，則讓其陣亡
            Hp -= ap;
            Console.WriteLine($"{Name} 受到 {ap} 點傷害，生命值剩余 {Hp}");

            if (Hp <= 0)
            {
                // 欄位 Dead 設為 true，表示單位已經陣亡
                Dead = true;
                Console.WriteLine($"{Name} 已經陣亡");
            }
        }

        return Dead;
    }

    ///
}

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

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