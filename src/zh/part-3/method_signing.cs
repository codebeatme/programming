/*
本节文章
https://learnscript.net/zh/programming/part-3/method-signing/ 什么是方法签名
*/

/// 类 Cannon，表示加农炮
class Cannon
{
    /// 第一个 Attack 方法，只有一个整型参数
    public void Attack(int point)
    {
        Console.WriteLine($"可造成 {point} 点伤害");
    }

    /// 第二个 Attack 方法，有一个整型参数和一个布尔型参数
    public void Attack(int point, bool critical)
    {
        Console.WriteLine($"可造成 {point} 点伤害 [暴击？{critical}]");
    }
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// 创建 Cannon 类的实例 cannon
Cannon cannon = new();

// 通过不同的参数，调用不同的 Attack 方法
// 调用第一个 Attack 方法
cannon.Attack(100);
// 调用第二个 Attack 方法
cannon.Attack(100, true);
*/