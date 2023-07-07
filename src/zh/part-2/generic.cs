/*
本节视频
https://www.bilibili.com/video/BV1zk4y1j7ry/ 「编程指南」什么是泛型和类型参数？如何使用泛型？泛型的作用

泛型也被称为模板，他可以使代码具有更广泛的适用性，并通过在使用时指定数据类型，来降低适用性带来的安全和效率问题
* 定义泛型时，使用类型参数代替数据类型
* 使用泛型时，将具体的数据类型传递给类型参数

版本
.NET 7.0.2
VSCode 1.78.0

相关视频
https://www.bilibili.com/video/BV1Dm4y1B7gi/ 什么是数据类型？数字类型和字符串类型的区别

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/*
以下代码与 generic_constraint.cs 只能有一个不被注释

/// 表示箱子的类，拥有类型参数 T
class Box<T>
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
*/

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 创建泛型类 Box<T> 的实例
// 打包苹果的箱子 appleBox
Box<Apple> appleBox = new Box<Apple>()
{ Name = "苹果箱子" };
// 打包宠物的箱子 petBox
Box<Pet> petBox = new Box<Pet>()
{ Name = "宠物箱子" };

/// Pack 方法只接收类型参数 T 表示的数据类型
// appleBox 的 Pack 方法只接收 Apple 对象
appleBox.Pack(new Apple());
// petBox 的 Pack 方法只接收 Pet 对象
petBox.Pack(new Pet());

// appleBox 的 Pack 方法不接收 Pet 对象
// appleBox.Pack(new Pet());

/// 显示箱子中的物品
appleBox.Show();
petBox.Show();
*/