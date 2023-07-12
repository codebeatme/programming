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