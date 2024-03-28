// 列舉 Color，表示色彩
public enum Color {
    // 未設定，0
    None,
    // 白色，1
    White,
    // 黑色，10
    Black = 10,
    // 紅色，11
    Red,
    // 藍色，100
    Blue = 100,
    // 黃色，101
    Yellow,
}

// 列舉 DayOfWeek，表示當周日次
public enum DayOfWeek
{
    // 未設定
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
請將以下程式碼複製到 Program.cs 中，以執行本節範例

// 組合成員 Monday 和 Tuesday
DayOfWeek days = DayOfWeek.Monday | DayOfWeek.Tuesday;
Console.WriteLine($"days={days}");

// 與 None 組合
Console.WriteLine($"與 None 組合後等於自身？{days == (days | DayOfWeek.None)}");

// 函式 Rest 將根據是否是周末來顯示資訊
void Rest(DayOfWeek dayOfWeek)
{
    DayOfWeek weekend = DayOfWeek.Saturday | DayOfWeek.Sunday;

    if ((weekend & dayOfWeek) == weekend)
        Console.WriteLine("休息兩天！");
    else if ((DayOfWeek.Saturday & dayOfWeek) == DayOfWeek.Saturday || (DayOfWeek.Sunday & dayOfWeek) == DayOfWeek.Sunday)
        Console.WriteLine("周末的味道！");
    else
        Console.WriteLine("枯燥的味道！");
}

// 傳遞周一，周五，周六的組合
Rest(DayOfWeek.Monday | DayOfWeek.Friday | DayOfWeek.Saturday);
// 傳遞周二，周三
Rest(DayOfWeek.Tuesday | DayOfWeek.Wednesday);
// 傳遞周四，周六，周日的組合
Rest(DayOfWeek.Thursday | DayOfWeek.Saturday | DayOfWeek.Sunday);
// 周一和周二的組合包含了 None
Console.WriteLine($"days 包含 None？{(days & DayOfWeek.None) == DayOfWeek.None}");

DayOfWeek day12 = DayOfWeek.Monday | DayOfWeek.Tuesday;
DayOfWeek day23 = DayOfWeek.Tuesday | DayOfWeek.Wednesday;
// 周二將被移除，周一和周三將被組合
DayOfWeek day13 = day12 ^ day23;
Console.WriteLine($"包含周一？{(day13 & DayOfWeek.Monday) == DayOfWeek.Monday}");
Console.WriteLine($"包含周二？{(day13 & DayOfWeek.Tuesday) == DayOfWeek.Tuesday}");
Console.WriteLine($"包含周三？{(day13 & DayOfWeek.Wednesday) == DayOfWeek.Wednesday}");
// 移除 None
Console.WriteLine($"移除 None 之後等於自身？{(day13 ^ DayOfWeek.None) == day13}");

// workdays 是工作日的組合
DayOfWeek workdays = ~(DayOfWeek.Saturday | DayOfWeek.Sunday);
Console.WriteLine($"周一是工作日？{(workdays & DayOfWeek.Monday) == DayOfWeek.Monday}");
Console.WriteLine($"周五是工作日？{(workdays & DayOfWeek.Friday) == DayOfWeek.Friday}");
Console.WriteLine($"相等？{workdays == (DayOfWeek.Monday | DayOfWeek.Tuesday | DayOfWeek.Wednesday | DayOfWeek.Thursday | DayOfWeek.Friday)}");
*/