/*
本节文章
https://learnscript.net/zh/programming/part-1/class-properties/ 什么是类的属性？属性和字段有何不同
*/

// 一个关于计划的类
class Plan
{
    /// 字段 Name，表示计划的名称
    public string Name = string.Empty;

    private int _totalDays;
    /// 属性 TotalDays，表示计划的总天数
    public int TotalDays
    {
        get => _totalDays;
        set
        {
            // 不能将总天数设置为小于 0
            if (value < 0)
                Console.WriteLine("总天数不能小于 0");
            else
                _totalDays = value;
        }
    }

    ///
    // // ERROR get_TotalDays 已经被占用
    // public int get_TotalDays()
    // {
    //     return 0;
    // }
    ///
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 创建实例 plan
Plan plan = new();

/// 访问字段 Name 和属性 TotalDays
// 设置计划的名称
plan.Name = "一个计划";

// 设置计划的总天数
plan.TotalDays = -100;

// 显示计划的信息
Console.WriteLine($"计划 “{plan.Name}” 一共持续 {plan.TotalDays} 天");
*/