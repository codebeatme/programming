/*
本節文章
https://learnscript.net/zh-hant/programming/part-1/class-properties/ 什麽是類別的屬性？屬性和欄位有何不同
*/

// 一個關於計劃的類別
class Plan
{
    /// 欄位 Name，表示計劃的名稱
    public string Name = string.Empty;

    private int _totalDays;
    /// 屬性 TotalDays，表示計劃的總天數
    public int TotalDays
    {
        get => _totalDays;
        set
        {
            // 不能將總天數設定為小於 0
            if (value < 0)
                Console.WriteLine("總天數不能小於 0");
            else
                _totalDays = value;
        }
    }

    ///
    // // ERROR get_TotalDays 已經被占用
    // public int get_TotalDays()
    // {
    //     return 0;
    // }
    ///
}

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

/// 建立執行個體 plan
Plan plan = new();

/// 存取欄位 Name 和屬性 TotalDays
// 設定計劃的名稱
plan.Name = "一個計劃";

// 設定計劃的總天數
plan.TotalDays = -100;

// 顯示計劃的資訊
Console.WriteLine($"計劃 “{plan.Name}” 一共持續 {plan.TotalDays} 天");
*/