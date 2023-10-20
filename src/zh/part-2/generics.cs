/*
本节文章
https://learnscript.net/zh/programming/part-2/generics-and-type-parameters/ 什么是泛型，类型参数？如何使用
*/

// 以下代码与 generic_constraint.cs 只能有一个不被注释

/// 类 Box，表示箱子，拥有类型参数 T
class Box<T>
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

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 创建泛型类 Box<T> 的实例
// 打包苹果的箱子 appleBox
Box<Apple> appleBox = new()
{ Name = "苹果箱子" };
// 打包宠物的箱子 petBox
Box<Pet> petBox = new()
{ Name = "宠物箱子" };

/// Pack 方法只接受类型参数 T 表示的数据类型
// appleBox 的 Pack 方法只接受 Apple 对象
appleBox.Pack(new Apple());
// petBox 的 Pack 方法只接受 Pet 对象
petBox.Pack(new Pet());

// ERROR appleBox 的 Pack 方法不接受 Pet 对象
// appleBox.Pack(new Pet());

/// 显示箱子中的物品
appleBox.Show();
petBox.Show();
*/