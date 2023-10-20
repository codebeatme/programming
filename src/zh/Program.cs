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

