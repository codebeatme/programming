/*
本节视频
https://www.bilibili.com/video/BV1UT411b7g2/ 「编程指南」什么是委托合并？委托合并的作用

委托合并也被称为委托多播，他可以被理解为，将多个委托合并到一个委托中，这个委托可以对多个方法或函数调用

版本
.NET 7.0.2
VSCode 1.77.3

相关视频
https://www.bilibili.com/video/BV1jo4y1c7aX/ 什么是委托？委托的作用

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 为英雄增加 5 点生命值
void Heal(MyHero hero) {
    hero.HP += 5;
}
// Heal 方法的委托
UseSkillDelegate heal = new UseSkillDelegate(Heal);

/// 击杀英雄
void Kill(MyHero hero) {
    hero.Dead = true;
}
// Kill 方法的委托
UseSkillDelegate kill = new UseSkillDelegate(Kill);

/// 合并委托
UseSkillDelegate combine = heal + kill;

/// 创建 MyHero 的实例
MyHero hero = new MyHero();
// 方法 Heal，Kill 将被调用
hero.UseSkill(combine);
Console.WriteLine(
    $"英雄生命值 {hero.HP}，阵亡？{hero.Dead}"
    );
*/