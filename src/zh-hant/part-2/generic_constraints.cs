/*
本節文章
https://learnscript.net/zh-hant/programming/part-2/generic-constraints/ 什麽是泛型條件約束
*/

/*
// 以下程式碼與 generics.cs 只能有一個不被註解

/// 類別 Box，表示箱子，擁有型別參數 T
class Box<T> where T : Pet
{
    // 箱子的名稱
    public string Name = "<一個箱子>";

    /// 箱子中包含的所有物品
    private List<T> items = new();

    /// 將物品 item 打包到箱子中
    public void Pack(T item)
    {
        items.Add(item);
    }

    /// 顯示箱子中的所有物品
    public void Show()
    {
        Console.WriteLine($"看看 {Name} 裏有什麽？");

        foreach (T item in items)
            Console.WriteLine(item);
    }

    ///
}

/// 類別 Apple，表示蘋果
class Apple
{
    public override string ToString()
    {
        return "一個蘋果！";
    }
}

/// 類別 Pet，表示寵物
class Pet
{
    public override string ToString()
    {
        return "一只寵物！";
    }
}
*/

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

// ERROR Box<T> 不能使用 Apple 類別
Box<Apple> box = new();
*/