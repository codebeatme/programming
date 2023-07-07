/*
本节视频
https://www.bilibili.com/video/BV1pT411H7TY/ 「编程指南」什么是接口？什么是实现接口？接口的作用

接口是一种设计约定，用来说明应该实现的方法或属性等
* 接口可应用于类，一些语言也支持应用于结构
* 如果类符合了接口的设计约定，那么就可以称，类实现了接口

版本
.NET 7.0.2
VSCode 1.77.3

相关视频
https://www.bilibili.com/video/BV1Dm4y1B7gi/ 什么是数据类型？数字类型和字符串类型的区别
https://www.bilibili.com/video/BV1bo4y1879U/ 什么是类？什么是对象和实例？类和对象实例的区别

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/*
以下代码与 interface_inherit.cs 只能有一个不被注释

/// 表示可读性的接口
interface IReadable
{
    // 当前的页码
    public int PageNumber { get; set; }
    // 获取当前页的内容
    public string GetContent();
}

/// 笔记本类，实现了接口 IReadable
class Note : IReadable
{
    /// 实现接口的属性 PageNumber
    public int PageNumber { get; set; } = 0;

    /// 实现了接口的方法 GetContent
    public string GetContent()
    {
        // 获取页码 PageNumber 指定的页的内容
        if (PageNumber >=0 && PageNumber < contents.Length)
            return contents[PageNumber];
        else
            // 如果 PageNumber 不合理，则返回空字符串
            return string.Empty;
    }

    /// 笔记本中包含的每页的内容
    string[] contents = new []{
        "这里是序章，我写了很多内容。。。",
        "这里是第1页内容。。。",
        "这里是第2页内容。。。",
        "这里是第3页内容。。。",
        "这里是第4页内容。。。",
    };
}
*/

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 读取并显示可读性内容
void ReadSomething(IReadable something)
{
    while(true){
        // 读取当前页内容，直到没有任何内容可读
        string content = something.GetContent();

        if(string.IsNullOrEmpty(content))
            break;

        // 显示当前页内容，并使页码加 1
        Console.WriteLine(content);
        something.PageNumber++;
    }
}

/// 创建 Note 类的实例，并通过 ReadSomething 显示其内容
Note note = new Note();
ReadSomething(note);
*/