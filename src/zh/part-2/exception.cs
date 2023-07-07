/*
本节视频
https://www.bilibili.com/video/BV1Eg4y157L9/ 「编程指南」什么是异常？抛出异常，捕获和处理异常

异常通常表示在程序运行时，出现的问题和错误
* 异常可由开发人员抛出，或自动抛出
* 要处理异常，需要先进行捕获

版本
.NET 7.0.2
VSCode 1.78.0

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 实现除法的方法，会检查除数是否有问题
int Divide(int dividend, int divisor)
{

    // 除数不能为 0，否则抛出异常
    if (divisor == 0)
        throw new Exception(
            $"参数 divisor 不能为 0！"
            );

    return dividend / divisor;
}

/// 用来捕获和处理异常的代码块
try
{
    // 除数为 0，将抛出异常
    Divide(7, 0);
}
catch (Exception err)
{
    // 简单的显示异常的信息，作为对异常的处理
    Console.WriteLine($"糟糕，出现一个异常！{err.Message}");
}
*/