/*
本節文章
https://learnscript.net/zh-hant/programming/part-2/delegate-combining-and-removing/ 什麽是委派合併，委派移除
*/

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

/// 為英雄增加 5 點生命值
void Heal(SuperHero hero)
{
    hero.Hp += 5;
}
// Heal 函式的委派
UseSkillDelegate heal = new(Heal);

/// 擊殺英雄
void Kill(SuperHero hero)
{
    hero.Dead = true;
}
// Kill 函式的委派
UseSkillDelegate kill = new(Kill);

/// 合併委派
UseSkillDelegate combine = heal + kill;

/// 建立 SuperHero 的執行個體
SuperHero hero = new();
// 函式 Heal，Kill 將被呼叫
hero.UseSkill(combine);
Console.WriteLine($"英雄生命值 {hero.Hp}，陣亡？{hero.Dead}");

// 移除 Heal 函式的委派
UseSkillDelegate? onlyKill = combine - heal;
*/