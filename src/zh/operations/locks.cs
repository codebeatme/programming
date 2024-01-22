/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// 余额，初始值为 1000
int balance = 1000;
// 用来请求锁的令牌
object locker = new();

// 函数 Pay，进行支付操作
void Pay(int amount)
{
    // 请求排他锁，确保只有一个目标正在访问 balance
    lock (locker)
    {
        balance -= amount;
        // 修改余额后等待 5 秒
        Thread.Sleep(5000);
    }
}

// 获取当前的余额
int GetBalance()
{
    // 请求排他锁，确保只有一个目标正在访问 balance
    lock (locker)
        return balance;
}

Console.WriteLine("开启一个线程，支付 100");
Thread thread = new(() => Pay(100));
thread.Start();

Console.WriteLine("现在我要查看余额！");
// 调用 GetBalance 将陷入等待，因为此时 Pay 方法持有锁
Console.WriteLine($"余额：{GetBalance()}");

// 用来请求锁的令牌
object lockerA = new();
object lockerB = new();

// 线程 I 先后使用令牌 lockerA，lockerB 获取排他锁
new Thread(() =>
{
    lock (lockerA)
    {
        Console.WriteLine("线程 I 已经获取锁 A");
        Thread.Sleep(2000);

        Console.WriteLine("线程 I 尝试获取锁 B");
        lock (lockerB)
            Console.WriteLine("线程 I 已经获取锁 B");
    }
}).Start();

// 线程 II 先后使用令牌 lockerB，lockerA 获取排他锁
new Thread(() =>
{
    lock (lockerB)
    {
        Console.WriteLine("线程 II 已经获取锁 B");
        Thread.Sleep(2000);

        Console.WriteLine("线程 II 尝试获取锁 A");
        lock (lockerA)
            Console.WriteLine("线程 II 已经获取锁 A");
    }
}).Start();

*/