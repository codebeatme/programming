/*
本节文章
https://learnscript.net/zh/programming/part-3/serial-parallel-concurrency/ 什么是串行，并行，并发？有何不同
*/

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// 执行第一个 for 循环的函数 fun1
void fun1()
{
    for (int i1 = 0; i1 < 10; i1++)
    {
        Console.WriteLine($"i1={i1}");
        // 挂起 0.5 秒
        Thread.Sleep(500);
    }
}
// 执行第二个 for 循环的函数 fun2
void fun2()
{
    for (int i2 = 0; i2 < 10; i2++)
    {
        Console.WriteLine($"i2={i2}");
        // 挂起 0.5 秒
        Thread.Sleep(500);
    }
}

// 通过两个线程来并行执行两个 for 循环
Thread thread1 = new(fun1);
Thread thread2 = new(fun2);

thread1.Start();
thread2.Start();
*/