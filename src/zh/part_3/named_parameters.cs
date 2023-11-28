/*
本节文章
https://learnscript.net/zh/programming/part-3/positional-and-named-parameters/ 什么是位置参数，命名参数？有何不同
*/

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 一个用于创建计划的函数
void CreatePlan(string name, int days, string leader, string[] members)
{
    // 显示计划的相关信息
    Console.WriteLine($"计划 {name}:");
    Console.WriteLine($"\t天数 {days}");
    Console.WriteLine($"\t领导 {leader}");
    Console.WriteLine($"\t成员 {members.Length} 个");

    foreach (string member in members)
        Console.WriteLine($"\t\t{member}");
}

/// 使用命名参数调用函数 CreatePlan
// CreatePlan(
//     name: "搬家计划",
//     days: 5,
//     leader: "铲屎官",
//     members: new[] { "阿猫", "阿狗" }
// );

/// 交换了参数 leader 和 days 的位置
// CreatePlan(
//     name: "搬家计划",
//     leader: "铲屎官",
//     days: 5,
//     members: new[] { "阿猫", "阿狗" }
// );

/// 使用位置参数调用函数 CreatePlan
// CreatePlan(
//     "另一个计划",
//     100,
//     "另一个铲屎官",
//     new[] { "喵喵" }
// );

/// 使用位置和命名参数两种方式调用函数 CreatePlan
CreatePlan(
    "另一个计划",
    days: 100,
    "另一个铲屎官",
    members: new[] { "喵喵" }
);
*/