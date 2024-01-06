/*
本節文章
https://learnscript.net/zh-hant/programming/part-2/delegates/ 什麽是委派
*/

/// 委派 HeroDelegate，用於 Heal 方法
delegate void HeroDelegate(SuperHero hero);

/// 類別 SuperHero，表示英雄
class SuperHero
{
    // 英雄是否陣亡
    public bool Dead = false;
    // 英雄的生命值
    public int Hp = 50;

    /// 方法 Heal 將在新的執行緒中執行
    public void Heal(object? callback)
    {
        // 為了看到效果，這裏等待 3 秒
        Thread.Sleep(3000);

        // 如果英雄已經死亡，則不需要治療
        if (!Dead)
        {
            // 恢復 5 點生命值
            Hp += 5;

            // 通知執行緒的建立者，治療完畢
            (callback as HeroDelegate)?.Invoke(this);
        }
    }

    ///
}

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

/// 函式 ShowStatus 用來顯示英雄的狀態
void ShowStatus(SuperHero hero)
{
    Console.WriteLine($"狀態更新，英雄生命值：{hero.Hp}");
}

// callback 將作為 Heal 方法的回呼目標
HeroDelegate callback = new(ShowStatus);

/// 建立 SuperHero 的執行個體
SuperHero hero = new();
// 建立執行緒執行 hero 的 Heal 方法
Thread thread = new(new ParameterizedThreadStart(hero.Heal));
// Heal 方法將呼叫 callback 包含的 ShowStatus 函式
thread.Start(callback);

Console.WriteLine("英雄貧血了？！");
*/