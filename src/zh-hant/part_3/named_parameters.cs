/*
本節文章
https://learnscript.net/zh-hant/programming/part-3/positional-and-named-parameters/ 什麽是位置參數，具名參數？有何不同
*/

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

/// 一個用於建立計劃的函式
void CreatePlan(string name, int days, string leader, string[] members)
{
    // 顯示計劃的相關資訊
    Console.WriteLine($"計劃 {name}:");
    Console.WriteLine($"\t天數 {days}");
    Console.WriteLine($"\t領導 {leader}");
    Console.WriteLine($"\t成員 {members.Length} 個");

    foreach (string member in members)
        Console.WriteLine($"\t\t{member}");
}

/// 使用具名參數呼叫函式 CreatePlan
// CreatePlan(
//     name: "搬家計劃",
//     days: 5,
//     leader: "鏟屎官",
//     members: new[] { "阿貓", "阿狗" }
// );

/// 交換了參數 leader 和 days 的位置
// CreatePlan(
//     name: "搬家計劃",
//     leader: "鏟屎官",
//     days: 5,
//     members: new[] { "阿貓", "阿狗" }
// );

/// 使用位置參數呼叫函式 CreatePlan
// CreatePlan(
//     "另一個計劃",
//     100,
//     "另一個鏟屎官",
//     new[] { "喵喵" }
// );

/// 使用位置和具名參數兩種方式呼叫函式 CreatePlan
CreatePlan(
    "另一個計劃",
    days: 100,
    "另一個鏟屎官",
    members: new[] { "喵喵" }
);
*/