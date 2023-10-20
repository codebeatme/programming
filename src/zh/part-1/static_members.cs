/*
本节文章
https://learnscript.net/zh/programming/part-1/class-static-and-instance-members/ 什么是类的静态，实例成员？有何不同
*/

// 一个关于狗狗的类
class Dog
{
    /// 静态字段，学名
    public static string FormalName = "狗狗";

    /// 实例字段，名字
    public string Name = "一只无名的狗";

    /// 静态字段，所有狗狗调用 Talk 的次数
    public static int TalkCount = 0;

    /// 实例方法，狗狗呼叫铲屎官
    public void Talk()
    {
        Console.WriteLine($"{Name}：“铲屎官何在？”");
        TalkCount += 1;
    }

    /// 静态方法，显示狗狗呼叫次数
    public static void ShowCount()
    {
        Console.WriteLine($"据狗狗联合会发布的数据，所有狗狗一共呼叫了 {TalkCount} 次铲屎官");
    }

    ///
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 创建 Dog 类的实例 dog1，dog2
Dog dog1 = new();
dog1.Name = "二哈典范";
Dog dog2 = new();

/// 分别访问字段和静态字段
Console.WriteLine($"名字：{dog1.Name}，学名：{Dog.FormalName}");
Console.WriteLine($"名字：{dog2.Name}，学名：{Dog.FormalName}");

///
dog1.Talk();
dog2.Talk();
dog1.Talk();
Dog.ShowCount();
*/