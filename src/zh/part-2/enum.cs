/*
本节视频
https://www.bilibili.com/video/BV1Sm4y1y7JN/ 「编程指南」什么是枚举？什么是枚举成员？如何使用枚举

枚举包含了一组有所关联的成员，每个成员对应了一个整型数字
* 第一个成员对应整型数字0，后续成员依次递增1
* 你也可以手动指定成员对应的数字

版本
.NET 7.0.2
VSCode 1.77.3

相关视频
https://www.bilibili.com/video/BV1Dm4y1B7gi/ 什么是数据类型？数字类型和字符串类型的区别
https://www.bilibili.com/video/BV1yM411N7Ti/ 什么是变量
https://www.bilibili.com/video/BV1bo4y1879U/ 什么是类？什么是对象和实例？类和对象实例的区别

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// 枚举 LightColor，表示亮色
enum LightColor
{
    /// 第一个枚举成员，默认对应整型数字 0
    White,
    /// 后续成员对应的整型数字，依次递增 1
    // 成员 Red = 1
    Red,
    // 成员 Green = 2
    Green,
    ///
}

/// 枚举 DarkColor，表示暗色
enum DarkColor
{
    /// 可以为成员指定其对应的整型数字
    Black = 100,
    Blue = 200
    ///
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 为枚举类型变量 color 赋值
LightColor color = LightColor.Green;

/// 读取枚举类型变量 color，并与枚举成员 Green 对比
if (color == LightColor.Green)
    Console.WriteLine("绿色让眼睛感觉舒适！");
*/