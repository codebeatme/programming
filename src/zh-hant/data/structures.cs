// 結構 MyDate，表示日期
struct MyDate
{
    // 欄位 Year，表示年份
    public int Year;
    // 欄位 Month，表示月份
    public int Month;
    // 欄位 Day，表示一月中的第幾天
    public int Day;
    // 欄位 Todo，表示當天需要完成的事情
    public TODO Todo = new();

    // 建構子
    public MyDate(int year, int month, int day)
    {
        // 初始化結構的欄位
        Year = year;
        Month = month;
        Day = day;
    }
}

// 類別 TODO，表示需要完成的事情
class TODO
{
    // 屬性 Content，表示事情的內容
    public string Content { get; set; } = string.Empty;
}

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

// 建立結構 MyDate 的執行個體
MyDate date = new(2024, 1, 16);

// 嘗試增加月份
for (int i = 0; i < 5; i++)
{
    // // 由於結構是實值型別，預設的傳值將產生一個新的結構執行個體
    // MyDate newDate = date;
    // 采用傳址不會產生新的執行個體，修改月份得到了滿意的效果
    ref MyDate newDate = ref date;
    newDate.Month++;
}

Console.WriteLine($"日期為：{date.Year}-{date.Month}-{date.Day}");

// 建立 MyDate 的執行個體 dateRest
MyDate dateRest = new(2000, 1, 16);
// 修改 Todo 表示的 TODO 執行個體的 Content 屬性
dateRest.Todo.Content = "沒什麽事情";

// 建立 MyDate 的執行個體 dateTodo
MyDate dateTodo = dateRest;
// 修改年份
dateTodo.Year = 2024;
// 修改 Todo 表示的 TODO 執行個體的 Content 屬性
dateTodo.Todo.Content = "有事了";

Console.WriteLine($"{dateRest.Year}-{dateRest.Month}-{dateRest.Day}：{dateRest.Todo.Content}");
Console.WriteLine($"{dateTodo.Year}-{dateTodo.Month}-{dateTodo.Day}：{dateTodo.Todo.Content}");
*/