/*
本節文章
https://learnscript.net/zh-hant/programming/part-3/method-signing/ 什麽是方法簽名
*/

/// 類別 Cannon，表示加農炮
class Cannon
{
    /// 第一個 Attack 方法，只有一個整數類型參數
    public void Attack(int point)
    {
        Console.WriteLine($"可造成 {point} 點傷害");
    }

    /// 第二個 Attack 方法，有一個整數類型參數和一個布林類型參數
    public void Attack(int point, bool critical)
    {
        Console.WriteLine($"可造成 {point} 點傷害 [暴擊？{critical}]");
    }
}

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

// 建立 Cannon 類別的執行個體 cannon
Cannon cannon = new();

// 通過不同的參數，呼叫不同的 Attack 方法
// 呼叫第一個 Attack 方法
cannon.Attack(100);
// 呼叫第二個 Attack 方法
cannon.Attack(100, true);
*/