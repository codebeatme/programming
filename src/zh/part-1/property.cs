/*
本节视频
https://www.bilibili.com/video/BV1Sv4y1E7wU/ 「编程指南」什么是类的属性？属性和字段的异同，属性的本质是方法

从外部使用的语法上看，类的属性和字段没有区别，但他们存在一些不同
* 属性一般包含一些简单的逻辑，用于对数据的合理性的检测
* 属性的本质是方法，而这项转换工作通常在编译时完成

版本
.NET 7.0.2
VSCode 1.77.3

相关视频
https://www.bilibili.com/video/BV1WL411m7UZ/ 什么是类的成员？什么是类的字段和方法

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// 类 Plan
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
                Console.WriteLine($"总天数不能小于 0");
            else
                _totalDays = value;

        }
    }

    ///
    // public int get_TotalDays() { return 0; }
    ///
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 创建实例 plan
Plan plan = new Plan();

/// 访问字段 Name 和属性 TotalDays
// 设置计划的名称
plan.Name = "一个计划";

// 设置计划的总天数
plan.TotalDays = -100;

// 显示计划的信息
Console.WriteLine(
    $"计划 “{plan.Name}” 一共持续 {plan.TotalDays} 天"
    );
*/