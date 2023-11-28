/*
本節文章
https://learnscript.net/zh-hant/programming/part-2/interfaces-and-implement/ 什麽是介面，實現介面
*/

// 以下程式碼與 interface_inheritance.cs 只能有一個不被註解

/// 介面 IReadable，表示可讀性
interface IReadable
{
    // 當前的頁碼
    public int PageNumber { get; set; }
    // 取得當前頁的內容
    public string GetContent();
}

/// 類別 Note，實現了介面 IReadable
class Note : IReadable
{
    /// 實現介面的屬性 PageNumber
    public int PageNumber { get; set; } = 0;

    /// 實現介面的方法 GetContent
    public string GetContent()
    {
        if (PageNumber >= 0 && PageNumber < contents.Length)
            // 取得頁碼 PageNumber 指定的頁的內容
            return contents[PageNumber];
        else
            // 如果 PageNumber 不合理，則傳回空字串
            return string.Empty;
    }

    /// 筆記本中包含的每頁的內容
    string[] contents = new[] {
        "這裏是序章，我寫了很多內容。。。",
        "這裏是第 1 頁內容。。。",
        "這裏是第 2 頁內容。。。",
        "這裏是第 3 頁內容。。。",
        "這裏是第 4 頁內容。。。",
    };
}

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

/// 讀取並顯示可讀性內容
void ReadSomething(IReadable something)
{
    while (true)
    {
        // 讀取當前頁內容，直到沒有任何內容可讀
        string content = something.GetContent();

        if (string.IsNullOrEmpty(content))
            break;

        // 顯示當前頁內容，並使頁碼加 1
        Console.WriteLine(content);
        something.PageNumber++;
    }
}

/// 建立 Note 類別的執行個體，並通過 ReadSomething 顯示其內容
Note note = new();
ReadSomething(note);
*/