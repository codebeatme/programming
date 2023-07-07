/*
本节视频
https://www.bilibili.com/video/BV1724y1T7eV/ 「编程指南」什么是生成？生成的作用

生成一般是指产生或创建一个可以迭代的对象，相对于直接定义或使用具有迭代功能的类，生成会更加简单

版本
.NET 7.0.2
VSCode 1.78.0

相关视频
https://www.bilibili.com/video/BV1aa4y1G7jj/ 什么是迭代？迭代的作用

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 返回一个可以进行迭代的对象，包含整数 1 到 5
System.Collections.IEnumerator GetNumbers()
{
    for (int i = 1; i <= 5; i++)
        // 使用 yield return 生成可迭代对象
        yield return i;
}

/// 将可迭代对象赋值给 numbers
var numbers = GetNumbers();

// 遍历并显示可迭代对象包含的元素
while(numbers.MoveNext())
    Console.WriteLine(numbers.Current);
*/