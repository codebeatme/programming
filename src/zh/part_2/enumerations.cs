/*
本节文章
https://learnscript.net/zh/programming/part-2/enumerations/ 什么是枚举？如何使用
*/

/// 枚举 LightColor，表示亮色
enum LightColor
{
    /// 第一个枚举成员，默认对应整数类型数字 0
    White,
    /// 后续成员对应的整数类型数字，依次递增 1
    // 成员 Red = 1
    Red,
    // 成员 Green = 2
    Green,
    ///
}

/// 枚举 DarkColor，表示暗色
enum DarkColor
{
    /// 可以为成员指定其对应的整数类型数字
    Black = 100,
    Blue = 200,
    ///
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 为枚举变量 color 赋值
LightColor color = LightColor.Green;

/// 读取枚举变量 color，并与枚举成员 Green 对比
if (color == LightColor.Green)
    Console.WriteLine("绿色让眼睛感觉舒适！");
*/