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

// 函式 Rest 將根據是否是周末來顯示資訊
void Rest(DayOfWeek dayOfWeek)
{

    if ((dayOfWeek & DayOfWeek.Saturday) == DayOfWeek.Saturday || (dayOfWeek & DayOfWeek.Sunday) == DayOfWeek.Sunday)
        Console.WriteLine("周末的味道！");
    else
        Console.WriteLine("枯燥的味道！");

}

// 傳遞周一，周五，周六的組合
Rest(DayOfWeek.Monday | DayOfWeek.Friday | DayOfWeek.Saturday);
// 傳遞周二，周三
Rest(DayOfWeek.Tuesday | DayOfWeek.Wednesday);

Console.WriteLine((int)Color.Red);
Console.WriteLine((int)Color.Yellow);
*/