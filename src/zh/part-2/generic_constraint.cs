/*
本节视频
https://www.bilibili.com/video/BV1jL411h7Bh/ 「编程指南」什么是泛型约束？泛型约束的作用

泛型约束是对泛型的使用进行的一种约束，以防止出现不符合预期的情况

版本
.NET 7.0.2
VSCode 1.78.0

相关视频
https://www.bilibili.com/video/BV1zk4y1j7ry/ 什么是泛型和类型参数？如何使用泛型？泛型的作用

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// 表示箱子的类，拥有类型参数 T
class Box<T>
where T : Pet
{
    //  箱子的名称
    public string Name = "<一个箱子>";

    /// 箱子中包含的所有物品
    private List<T> items = new List<T>();

    /// 将物品 item 打包到箱子中
    public void Pack(T item)
    {
        items.Add(item);
    }

    /// 显示箱子中的所有物品
    public void Show()
    {
        Console.WriteLine($"看看{Name}里有什么？");

        foreach (T item in items)
            Console.WriteLine(item);
    }

    ///
}

/// 表示苹果的类
class Apple
{
    public override string ToString()
    {
        return "一个苹果！";
    }
}

/// 表示宠物的类
class Pet
{
    public override string ToString()
    {
        return "一只宠物！";
    }
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

Box<Apple> box = new Box<Apple>();
*/