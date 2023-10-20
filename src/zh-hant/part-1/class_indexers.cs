/*
本節文章
https://learnscript.net/zh-hant/programming/part-1/class-indexers/ 什麽是類別的索引子
*/

/// 類別 Food，表示食物
class Food
{

    /// 欄位 _names，表示所有食物的名稱
    private string[] _names = new[] {
        "湯", "沙拉", "甜點", "茶"
        };

    /// 索引子，通過整型參數獲得食物名稱
    public string this[int i]
    {
        get { return _names[i]; }
    }

    /// 屬性 Count，表示食物種類的數量
    public int Count
    {
        get { return _names.Length; }
    }

    ///
}

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

/// 建立 Food 的執行個體
Food food = new();

/// 使用索引子顯示所有食物的名稱
Console.WriteLine("今天供應以下食物：");

for (int i = 0; i < food.Count; i++)
    Console.WriteLine($"\t{food[i]}");
*/