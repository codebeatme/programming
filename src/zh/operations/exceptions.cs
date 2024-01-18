/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// 函数 Divide，实现除法，会检查除数是否有问题
int Divide(int dividend, int divisor)
{

    // 除数不能为 0，否则抛出异常
    if (divisor == 0)
        throw new Exception("参数 divisor 不能为 0！");

    return dividend / divisor;
}

// 捕获和处理异常
try
{
    // 除数为 0，将抛出异常
    Divide(7, 0);
}
catch (Exception err)
{
    // 简单的显示异常的信息
    Console.WriteLine($"糟糕，出现一个异常！{err.Message}");
}
*/