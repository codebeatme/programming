/*
本節文章
https://learnscript.net/zh-hant/programming/part-1/classes-objects-instances/ 什麽是類別，物件，執行個體
*/

// 一個關於貓咪的類別
class Cat
{
    /// 貓咪名字，出生日期
    public string? name;
    public DateTime birthdate;

    /// 計算貓咪的年齡
    public int GetAge()
    {
        TimeSpan span = DateTime.Now - birthdate;

        return Convert.ToInt32(span.TotalDays / 365);
    }

    ///
}

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

/// 建立執行個體
Cat cat = new();

/// 設定名字，出生日期
cat.name = "小花";
cat.birthdate = new(2020, 3, 1);

/// 顯示年齡
Console.WriteLine($"{cat.name} 今年 {cat.GetAge()} 歲了！");
*/
