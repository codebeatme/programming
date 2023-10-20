/*
本節文章
https://learnscript.net/zh-hant/programming/part-2/interface-inheritance-base-and-derived-interfaces/ 什麽是介面的繼承，基礎介面，衍生介面
*/

/*
// 以下程式碼與 interfaces.cs 只能有一個不被註解

/// 介面 IReadable，表示可讀性
interface IReadable
{
    // 當前的頁碼
    int PageNumber { get; set; }
    // 取得當前頁的內容
    string GetContent();
}

/// 介面 IEditable，繼承自 IReadable，表示可編輯
interface IEditable : IReadable
{
    // 設定某一頁的內容
    void SetContent(int pageNumber, string content);
}

/// 類別 Note，實現了介面 IEditable
class Note : IEditable
{
    /// 實現介面的屬性 PageNumber
    public int PageNumber { get; set; } = 0;

    /// 實現介面的方法 GetContent
    public string GetContent()
    {
        // 取得屬性 PageNumber 指定的頁的內容
        if (PageNumber >= 0 && PageNumber < contents.Length)
            return contents[PageNumber];
        else
            // 如果 PageNumber 不合理，則傳回空字串
            return string.Empty;
    }

    /// 實現介面的方法 SetContent
    public void SetContent(int pageNumber, string content)
    {
        // 如果頁碼 pageNumber 是合理的，則設定對應頁的內容
        if (pageNumber >= 0 && pageNumber < contents.Length)
            contents[pageNumber] = content;
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
*/

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

/// 通過介面來使用 Note 類別
IEditable edit = new Note();
// 修改序章的內容
edit.SetContent(0, "我又修改了一下序章的內容。。。");
// 顯示所有頁的內容
ReadSomething(edit);
*/