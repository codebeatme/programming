/*
本节文章
https://learnscript.net/zh/programming/part-2/delegate-combining-and-removing/ 什么是委托合并，委托移除
*/

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 为英雄增加 5 点生命值
void Heal(SuperHero hero)
{
    hero.Hp += 5;
}
// Heal 函数的委托
UseSkillDelegate heal = new(Heal);

/// 击杀英雄
void Kill(SuperHero hero)
{
    hero.Dead = true;
}
// Kill 函数的委托
UseSkillDelegate kill = new(Kill);

/// 合并委托
UseSkillDelegate combine = heal + kill;

/// 创建 SuperHero 的实例
SuperHero hero = new();
// 函数 Heal，Kill 将被调用
hero.UseSkill(combine);
Console.WriteLine($"英雄生命值 {hero.Hp}，阵亡？{hero.Dead}");

// 移除 Heal 函数的委托
UseSkillDelegate? onlyKill = combine - heal;
*/