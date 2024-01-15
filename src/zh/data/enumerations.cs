// 枚举 Color，表示颜色
public enum Color {
    // 未设置，0
    None,
    // 白色，1
    White,
    // 黑色，10
    Black = 10,
    // 红色，11
    Red,
    // 蓝色，100
    Blue = 100,
    // 黄色，101
    Yellow,
}

// 枚举 DayOfWeek，表示星期几
public enum DayOfWeek
{
    // 未设置
    None = 0,
    // 周一
    Monday = 1,
    // 周二
    Tuesday = 2,
    // 周三
    Wednesday = 4,
    // 周四
    Thursday = 8,
    // 周五
    Friday = 16,
    // 周六
    Saturday = 32,
    // 周日
    Sunday = 64,
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// 组合成员 Monday 和 Tuesday
DayOfWeek days = DayOfWeek.Monday | DayOfWeek.Tuesday;

Console.WriteLine($"days={days}");

// 函数 Rest 将根据是否是周末来显示信息
void Rest(DayOfWeek dayOfWeek)
{

    if ((dayOfWeek & DayOfWeek.Saturday) == DayOfWeek.Saturday || (dayOfWeek & DayOfWeek.Sunday) == DayOfWeek.Sunday)
        Console.WriteLine("周末的味道！");
    else
        Console.WriteLine("枯燥的味道！");

}

// 传递周一，周五，周六的组合
Rest(DayOfWeek.Monday | DayOfWeek.Friday | DayOfWeek.Saturday);
// 传递周二，周三
Rest(DayOfWeek.Tuesday | DayOfWeek.Wednesday);

Console.WriteLine((int)Color.Red);
Console.WriteLine((int)Color.Yellow);
*/