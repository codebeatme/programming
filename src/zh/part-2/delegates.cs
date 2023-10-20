/*
本节文章
https://learnscript.net/zh/programming/part-2/delegates/ 什么是委托
*/

/// 委托 HeroDelegate，用于 Heal 方法
delegate void HeroDelegate(SuperHero hero);

/// 类 SuperHero，表示英雄
class SuperHero
{
    // 英雄是否阵亡
    public bool Dead = false;
    // 英雄的生命值
    public int Hp = 50;

    /// 方法 Heal 将在新的线程中执行
    public void Heal(object? callback)
    {
        // 为了看到效果，这里等待 3 秒
        Thread.Sleep(3000);

        // 如果英雄已经死亡，则不需要治疗
        if (!Dead)
        {
            // 恢复 5 点生命值
            Hp += 5;

            // 通知线程的创建者，治疗完毕
            (callback as HeroDelegate)?.Invoke(this);
        }
    }

    ///
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 函数 ShowStatus 用来显示英雄的状态
void ShowStatus(SuperHero hero)
{
    Console.WriteLine($"状态更新，英雄生命值：{hero.Hp}");
}

// callback 将作为 Heal 方法的回调目标
HeroDelegate callback = new(ShowStatus);

/// 创建 SuperHero 的实例
SuperHero hero = new();
// 创建线程执行 hero 的 Heal 方法
Thread thread = new(new ParameterizedThreadStart(hero.Heal));
// Heal 方法将调用 callback 包含的 ShowStatus 函数
thread.Start(callback);

Console.WriteLine("英雄贫血了？！");
*/