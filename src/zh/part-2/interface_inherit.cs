/*
本节视频
https://www.bilibili.com/video/BV13a4y157jA/ 「编程指南」什么是接口的继承？什么是基接口和派生接口

接口继承是对接口声明和定义的成员，进行调整和扩展的一种方式
* 被继承的接口，被称为基接口，父接口
* 继承自基接口的接口，被称为派生接口或子接口

更正
结尾提到的“下一节将说明接口的显式实现”，其中的显式应为显式

版本
.NET 7.0.2
VSCode 1.77.3

相关视频
https://www.bilibili.com/video/BV1bo4y1879U/ 什么是类？什么是对象和实例？类和对象实例的区别
https://www.bilibili.com/video/BV1PV4y1f7SV/ 什么是类的继承？什么是基类和派生类？继承的作用，以及不能被继承的成员

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// 表示可读性的接口
interface IReadable
{
    // 当前的页码
    int PageNumber { get; set; }
    // 获取当前页的内容
    string GetContent();
}

/// 表示可编辑的接口，继承自 IReadable
interface IEditable : IReadable
{
    // 设置某一页的内容
    void SetContent(int pageNumber, string content);
}

/// 笔记本类，实现了接口 IEditable
class Note : IEditable
{
    /// 实现接口的属性 PageNumber
    public int PageNumber { get; set; } = 0;

    /// 实现接口的方法 GetContent
    public string GetContent()
    {
        // 获取属性 PageNumber 指定的页的内容
        if (PageNumber >= 0 && PageNumber < contents.Length)
            return contents[PageNumber];
        else
            // 如果 PageNumber 不合理，则返回空字符串
            return string.Empty;
    }

    /// 实现接口的方法 SetContent
    public void SetContent(int pageNumber, string content)
    {
        // 如果页码 pageNumber 是合理的，则设置对应页的内容
        if (pageNumber >= 0 && pageNumber < contents.Length)
            contents[pageNumber] = content;
    }

    /// 笔记本中包含的每页的内容
    string[] contents = new[]{
        "这里是序章，我写了很多内容。。。",
        "这里是第1页内容。。。",
        "这里是第2页内容。。。",
        "这里是第3页内容。。。",
        "这里是第4页内容。。。",
    };
}

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

/// 通过接口来使用 Note 类
IEditable edit = new Note();
// 修改序章的内容
edit.SetContent(0, "我又修改了一下序章的内容。。。");
// 显示所有页的内容
ReadSomething(edit);
*/