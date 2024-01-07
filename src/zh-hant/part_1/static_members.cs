/*
本節文章
https://learnscript.net/zh-hant/programming/part-1/class-static-and-instance-members/ 什麽是類別的靜態，執行個體成員？有何不同
*/

// 一個關於狗狗的類別
class Dog
{
    /// 靜態欄位，學名
    public static string FormalName = "狗狗";

    /// 執行個體欄位，名字
    public string Name = "一只無名的狗";

    /// 靜態欄位，所有狗狗呼叫 Talk 的次數
    public static int TalkCount = 0;

    /// 執行個體方法，狗狗呼喚鏟屎官
    public void Talk()
    {
        Console.WriteLine($"{Name}：“鏟屎官何在？”");
        TalkCount += 1;
    }

    /// 靜態方法，顯示狗狗呼喚次數
    public static void ShowCount()
    {
        Console.WriteLine($"據狗狗聯合會發布的資料，所有狗狗一共呼喚了 {TalkCount} 次鏟屎官");
    }

    ///
}

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

/// 建立 Dog 類別的執行個體 dog1，dog2
Dog dog1 = new();
dog1.Name = "二哈典範";
Dog dog2 = new();

/// 分別存取欄位和靜態欄位
Console.WriteLine($"名字：{dog1.Name}，學名：{Dog.FormalName}");
Console.WriteLine($"名字：{dog2.Name}，學名：{Dog.FormalName}");

///
dog1.Talk();
dog2.Talk();
dog1.Talk();
Dog.ShowCount();
*/