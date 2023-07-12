/*
本节视频
https://www.bilibili.com/video/BV18o4y1b7Y2/ 「编程指南」什么是方法重载？如何调用重载方法？可重载成员还有哪些

本节文章
https://learnscript.net/zh/programming/part-1/method-overloading-and-call/ 什么是方法重载？如何调用
*/

/// 一个关于你的信息的类
class YourInfo
{

    /// 第一个方法 Show，有一个字符串类型的参数
    public void Show(string fullName)
    {
        Console.WriteLine($"全名 “{fullName}”");
    }

    /// 第二个方法 Show，虽然也是只有一个参数，但该参数的类型为整型，所以没有问题
    public void Show(int age)
    {
        Console.WriteLine($"年龄 {age}");
    }

    /// 第三个方法 Show，有两个参数，因此也没有问题
    public virtual void Show(string firstName, string lastName)
    {
        Console.WriteLine(
            $"姓 “{lastName}”，名字 “{firstName}”"
            );
    }

}

/// 一个关于我的信息的类
class MyInfo : YourInfo
{
    // 这里的 Show 方法，没有重写或隐藏基类的任何方法
    public void Show()
    { }
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 创建 YourInfo 的实例
YourInfo info = new YourInfo();

/// 传递不同的参数，以调用不同的 Show 方法
info.Show("小明");
info.Show(13);
info.Show("小锤", "王");
*/