// 结构 MyDate，表示日期
struct MyDate
{
    // 字段 Year，表示年份
    public int Year;
    // 字段 Month，表示月份
    public int Month;
    // 字段 Day，表示一月中的第几天
    public int Day;
    // 字段 Todo，表示当天需要完成的事情
    public TODO Todo = new();

    // 构造器
    public MyDate(int year, int month, int day)
    {
        // 初始化结构的字段
        Year = year;
        Month = month;
        Day = day;
    }
}

// 类 TODO，表示需要完成的事情
class TODO
{
    // 属性 Content，表示事情的内容
    public string Content { get; set; } = string.Empty;
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// 创建结构 MyDate 的实例
MyDate date = new(2024, 1, 16);

// 尝试增加月份
for (int i = 0; i < 5; i++)
{
    // // 由于结构是值类型，默认的值传递将产生一个新的结构实例
    // MyDate newDate = date;
    // 采用引用传递不会产生新的实例，修改月份得到了满意的效果
    ref MyDate newDate = ref date;
    newDate.Month++;
}

Console.WriteLine($"日期为：{date.Year}-{date.Month}-{date.Day}");

// 创建 MyDate 的实例 dateRest
MyDate dateRest = new(2000, 1, 16);
// 修改 Todo 表示的 TODO 实例的 Content 属性
dateRest.Todo.Content = "没什么事情";

// 创建 MyDate 的实例 dateTodo
MyDate dateTodo = dateRest;
// 修改年份
dateTodo.Year = 2024;
// 修改 Todo 表示的 TODO 实例的 Content 属性
dateTodo.Todo.Content = "有事了";

Console.WriteLine($"{dateRest.Year}-{dateRest.Month}-{dateRest.Day}：{dateRest.Todo.Content}");
Console.WriteLine($"{dateTodo.Year}-{dateTodo.Month}-{dateTodo.Day}：{dateTodo.Todo.Content}");
*/