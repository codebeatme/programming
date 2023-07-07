/*
本节视频
https://www.bilibili.com/video/BV18o4y1b7Y2/ 「编程指南」什么是方法重载？如何调用重载方法？可重载成员还有哪些

方法重载允许你创建多个同名的方法
* 方法的参数不能相同，包括参数类型的不同，或参数个数的不同
* 将根据传递的参数，确定具体调用哪一个方法
* 类的其他成员也可以支持重载，比如，运算符

补充
在某些编程语言中，方法重载的条件可能有所变化，比如，C#中添加ref或out关键字，也会被认为是不同的参数

版本
.NET 7.0.2
VSCode 1.77.3

相关视频
https://www.bilibili.com/video/BV1Xh41177AA/ 什么是方法重写？方法重写有什么用
https://www.bilibili.com/video/BV1Qo4y1j7Lj/ 什么是方法隐藏？方法隐藏的作用，隐藏和重写的区别，可隐藏成员还有哪些

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// 类 YourInfo
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

/// 类 MyInfo
class MyInfo : YourInfo
{
    // 这里的 Show 方法，没有重写或隐藏基类的任何方法
    public void Show()
    {}
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

YourInfo info = new YourInfo();

info.Show("小明");
info.Show(13);
info.Show("小锤", "王");
*/