/*
本節文章
https://learnscript.net/zh-hant/programming/part-1/method-overloading-and-call/ 什麽是方法多載？如何呼叫
*/

/// 一個關於資訊的類別
class Info
{

    /// 第一個方法 Show，有一個字串型別的參數
    public void Show(string fullName)
    {
        Console.WriteLine($"全名 “{fullName}”");
    }

    /// 第二個方法 Show，雖然也是只有一個參數，但該參數的型別為整型，所以沒有問題
    public void Show(int age)
    {
        Console.WriteLine($"年齡 {age}");
    }

    /// 第三個方法 Show，有兩個參數，因此也沒有問題
    public virtual void Show(string firstName, string lastName)
    {
        Console.WriteLine($"姓 “{lastName}”，名字 “{firstName}”");
    }

}

/// 一個關於工人資訊的類別
class WorkerInfo : Info
{
    // 這裏的 Show 方法，沒有覆寫或遮蔽基礎類別的任何方法
    public void Show()
    { }
}

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

/// 建立 Info 的執行個體
Info info = new();

/// 傳遞不同的參數，以呼叫不同的 Show 方法
info.Show("小明");
info.Show(13);
info.Show("小錘", "王");
*/