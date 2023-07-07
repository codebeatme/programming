/*
本节视频
https://www.bilibili.com/video/BV1QX4y1y75Y/ 「编程指南」什么是默认参数？默认参数的作用

默认参数可以让方法和函数被轻松的使用
* 你可以不为默认参数指定具体的值，在调用相关方法和函数时
* 此时，默认参数将使用定义时被设置的默认值

版本
.NET 7.0.2
VSCode 1.78.2

相关视频
https://www.bilibili.com/video/BV1sa4y1T7WU/ 什么是函数？什么是函数的参数和返回值

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 显示欢迎消息的函数
void Welcome(
    string name,
    // message 是一个默认参数，拥有默认值 "你好！{0}"
    string message = "你好！{0}"
    )
{
    Console.WriteLine(message, name);
}

/// 可以不为默认参数 message 指定值
Welcome("大花猫");
*/