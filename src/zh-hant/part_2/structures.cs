/*
本節文章
https://learnscript.net/zh-hant/programming/part-2/structures/ 什麽是結構？結構和類別有何不同
*/

/// 結構 Book，表示書籍的相關資訊
struct Book
{
    /// 欄位 Name 表示書名，Isbn 表示書號
    public string Name;
    public string Isbn;

    /// 方法 ShowInfo，顯示書籍的資訊
    public void ShowInfo()
    {
        Console.WriteLine($"書名 {Name}，書號 {Isbn}");
    }

    /// 靜態成員，與書籍的總數量相關
    public static int Count = 0;
    public static void ShowCount()
    {
        Console.WriteLine($"書籍總數量為：{Count}");
    }
}

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

/// 建立結構，並通過 book1 指派給 book2，book1 和 book2 儲存了各自的結構
Book book1 = new()
{
    Name = "我是一本書",
    Isbn = "一個合理的書號"
};
Book book2 = book1;

/// 修改 book2 中的結構的欄位
book2.Name = "這不是書";
book2.Isbn = "這不是書號";

/// book1 中的結構不受影響
book1.ShowInfo();
*/