/*
本節文章
https://learnscript.net/zh-hant/programming/part-2/generics-and-type-parameters/ 什麽是泛型，型別參數？如何使用
*/

// 以下程式碼與 generic_constraint.cs 只能有一個不被註解

/// 類別 Box，表示箱子，擁有型別參數 T
class Box<T>
{
    // 箱子的名稱
    public string Name = "<一個箱子>";

    /// 箱子中包含的所有物品
    private List<T> items = new();

    /// 將物品 item 封裝到箱子中
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

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

/// 建立泛型類別 Box<T> 的執行個體
// 封裝蘋果的箱子 appleBox
Box<Apple> appleBox = new()
{ Name = "蘋果箱子" };
// 封裝寵物的箱子 petBox
Box<Pet> petBox = new()
{ Name = "寵物箱子" };

/// Pack 方法只接受型別參數 T 表示的資料型別
// appleBox 的 Pack 方法只接受 Apple 物件
appleBox.Pack(new Apple());
// petBox 的 Pack 方法只接受 Pet 物件
petBox.Pack(new Pet());

// ERROR appleBox 的 Pack 方法不接受 Pet 物件
// appleBox.Pack(new Pet());

/// 顯示箱子中的物品
appleBox.Show();
petBox.Show();
*/