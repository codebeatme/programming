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