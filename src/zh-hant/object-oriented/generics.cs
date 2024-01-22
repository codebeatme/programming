// 類別 Box，表示儲存內容的箱子
class Box
{
    // 欄位 items，一個簡單的陣列
    object[] items;

    // 建構子，可以初始化 items
    public Box(params object[] i)
    {
        items = i ?? Array.Empty<object>();
    }

    // 泛型方法 GetFirst，取得陣列中第一個類型為 T 的元素
    // public T? GetFirst<T>()
    public T? GetFirst<T>() where T : class
    {
        // 如果元素的類型與 T 一致，則傳回
        foreach (object item in items)
            if (item.GetType() == typeof(T))
                return (T)item;

        return default;
    }
}

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

// 類型參數 T 被指定為 string
List<string> nicknames = new();

// 建立 Box 的執行個體 box
Box box = new("第一個字串", 123, "第二個字串", 234, 0.123f, 0.234f);
// 取得 box 中的第一個字串
Console.WriteLine(box.GetFirst<string>());
// 取得 box 中的第一個整數
Console.WriteLine(box.GetFirst<int>());
// 取得 box 中的第一個浮點數
Console.WriteLine(box.GetFirst<float>());
*/