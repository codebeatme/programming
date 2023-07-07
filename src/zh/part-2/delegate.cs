/*
本节视频
https://www.bilibili.com/video/BV1jo4y1c7aX/ 「编程指南」什么是委托？委托的作用

委托包含对方法或函数的引用，并可通过引用调用方法和函数

版本
.NET 7.0.2
VSCode 1.77.3

相关视频
https://www.bilibili.com/video/BV1Dm4y1B7gi/ 什么是数据类型？数字类型和字符串类型的区别
https://www.bilibili.com/video/BV1bo4y1879U/ 什么是类？什么是对象和实例？类和对象实例的区别

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// 定义表示使用技能的委托 UseSkillDelegate
delegate void UseSkillDelegate(MyHero hero);

/// 表示英雄的类
class MyHero
{
    // 英雄是否阵亡
    public bool Dead = false;
    // 英雄的生命值
    public int HP = 50;

    /// 方法 UseSkill 的代码逻辑已经固定，但委托可以让该方法实现不同的功能
    public void UseSkill(UseSkillDelegate useSkill)
    {
        // 如果英雄已经死亡，则不能使用任何技能
        if (!Dead)
            useSkill(this);
    }

    ///
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 为英雄增加 5 点生命值
void Heal(MyHero hero) {
    hero.HP += 5;
}
// Heal 方法的委托
UseSkillDelegate heal = new UseSkillDelegate(Heal);

/// 创建 MyHero 的实例
MyHero hero = new MyHero();
// UseSkill 将调用委托类型变量 heal 所引用的 Heal 方法
hero.UseSkill(heal);
*/