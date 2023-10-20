/*
本节文章
https://learnscript.net/zh/programming/part-3/locks/ 什么是锁
*/

// 类 CreditCard，表示银行卡
class CreditCard
{
    // 银行卡余额，初始值为 1000
    private static int balance = 1000;
    // 用来判断锁状态的对象
    private static readonly object locker = new();

    // 银行卡进行支付操作，支付金额为 amount
    public static void Pay(int amount)
    {
        // 确保同时只能有一个线程访问 balance 字段
        lock (locker)
        {
            balance -= amount;
            // 挂起 5 秒
            Thread.Sleep(5000);
        }
    }

    // 获取当前的银行卡余额
    public static int GetBalance()
    {
        // 确保同时只能有一个线程访问 balance 字段
        lock (locker)
            return balance;
    }

}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// 一个用于被新线程调用的函数
void PayForMe()
{
    // 使用信用卡支付
    CreditCard.Pay(100);
}

Console.WriteLine("开启一个线程，为我支付 100");
Thread thread = new(PayForMe);
thread.Start();

// 由于是在新线程中调用 PayForMe，主线程将很快执行到这里
Console.WriteLine("现在我要查看余额了哦！");
// 调用 GetBalance 将陷入等待，因为此时 Pay 方法持有锁
Console.WriteLine($"余额：{CreditCard.GetBalance()}");
*/