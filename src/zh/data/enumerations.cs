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

// 与 None 组合
Console.WriteLine($"与 None 组合后等于自身？{days == (days | DayOfWeek.None)}");

// 函数 Rest 将根据是否是周末来显示信息
void Rest(DayOfWeek dayOfWeek)
{
    DayOfWeek weekend = DayOfWeek.Saturday | DayOfWeek.Sunday;

    if ((weekend & dayOfWeek) == weekend)
        Console.WriteLine("休息两天！");
    else if ((DayOfWeek.Saturday & dayOfWeek) == DayOfWeek.Saturday || (DayOfWeek.Sunday & dayOfWeek) == DayOfWeek.Sunday)
        Console.WriteLine("周末的味道！");
    else
        Console.WriteLine("枯燥的味道！");
}

// 传递周一，周五，周六的组合
Rest(DayOfWeek.Monday | DayOfWeek.Friday | DayOfWeek.Saturday);
// 传递周二，周三
Rest(DayOfWeek.Tuesday | DayOfWeek.Wednesday);
// 传递周四，周六，周日的组合
Rest(DayOfWeek.Thursday | DayOfWeek.Saturday | DayOfWeek.Sunday);
// 周一和周二的组合包含了 None
Console.WriteLine($"days 包含 None？{(days & DayOfWeek.None) == DayOfWeek.None}");

DayOfWeek day12 = DayOfWeek.Monday | DayOfWeek.Tuesday;
DayOfWeek day23 = DayOfWeek.Tuesday | DayOfWeek.Wednesday;
// 周二将被移除，周一和周三将被组合
DayOfWeek day13 = day12 ^ day23;
Console.WriteLine($"包含周一？{(day13 & DayOfWeek.Monday) == DayOfWeek.Monday}");
Console.WriteLine($"包含周二？{(day13 & DayOfWeek.Tuesday) == DayOfWeek.Tuesday}");
Console.WriteLine($"包含周三？{(day13 & DayOfWeek.Wednesday) == DayOfWeek.Wednesday}");
// 移除 None
Console.WriteLine($"移除 None 之后等于自身？{(day13 ^ DayOfWeek.None) == day13}");

// workdays 是工作日的组合
DayOfWeek workdays = ~(DayOfWeek.Saturday | DayOfWeek.Sunday);
Console.WriteLine($"周一是工作日？{(workdays & DayOfWeek.Monday) == DayOfWeek.Monday}");
Console.WriteLine($"周五是工作日？{(workdays & DayOfWeek.Friday) == DayOfWeek.Friday}");
Console.WriteLine($"相等？{workdays == (DayOfWeek.Monday | DayOfWeek.Tuesday | DayOfWeek.Wednesday | DayOfWeek.Thursday | DayOfWeek.Friday)}");
*/