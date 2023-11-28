/*
本节文章
https://learnscript.net/zh/programming/part-2/generic-constraints/ 什么是泛型约束
*/

/*
// 以下代码与 generics.cs 只能有一个不被注释

/// 类 Box，表示箱子，拥有类型参数 T
class Box<T> where T : Pet
{
    // 箱子的名称
    public string Name = "<一个箱子>";

    /// 箱子中包含的所有物品
    private List<T> items = new();

    /// 将物品 item 打包到箱子中
    public void Pack(T item)
    {
        items.Add(item);
    }

    /// 显示箱子中的所有物品
    public void Show()
    {
        Console.WriteLine($"看看 {Name} 里有什么？");

        foreach (T item in items)
            Console.WriteLine(item);
    }

    ///
}

/// 类 Apple，表示苹果
class Apple
{
    public override string ToString()
    {
        return "一个苹果！";
    }
}

/// 类 Pet，表示宠物
class Pet
{
    public override string ToString()
    {
        return "一只宠物！";
    }
}
*/

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// ERROR Box<T> 不能使用 Apple 类
Box<Apple> box = new();
*/