/*
本节视频
https://www.bilibili.com/video/BV1cm4y1a7XZ/ 「编程指南」什么是可变参数？可变参数的本质是数组

可变参数使得方法或函数，可输入的参数个数是不确定的
* 可变参数之后，不能再定义其他参数
* 可变参数本质上是通过数组来实现的

版本
.NET 7.0.2
VSCode 1.78.2

相关视频
https://www.bilibili.com/video/BV1sa4y1T7WU/ 什么是函数？什么是函数的参数和返回值

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 显示一组水果信息的函数
void ListFruit(
    // list 是一个可变参数
    params Fruit[] list
    )
{
    Console.WriteLine($"一共有 ${list.Length} 个水果");

    foreach (Fruit fruit in list)
        Console.WriteLine(fruit);
}

/// 可以为 ListFruit 指定多个 Fruit 和其派生类的实例
ListFruit(
    new Fruit(),
    new Orange(),
    new Orange(),
    new Fruit()
);
*/