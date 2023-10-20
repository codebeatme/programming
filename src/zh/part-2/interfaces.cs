/*
本节文章
https://learnscript.net/zh/programming/part-2/interfaces-and-implement/ 什么是接口，实现接口
*/

// 以下代码与 interface_inheritance.cs 只能有一个不被注释

/// 接口 IReadable，表示可读性
interface IReadable
{
    // 当前的页码
    public int PageNumber { get; set; }
    // 获取当前页的内容
    public string GetContent();
}

/// 类 Note，实现了接口 IReadable
class Note : IReadable
{
    /// 实现接口的属性 PageNumber
    public int PageNumber { get; set; } = 0;

    /// 实现接口的方法 GetContent
    public string GetContent()
    {
        if (PageNumber >= 0 && PageNumber < contents.Length)
            // 获取页码 PageNumber 指定的页的内容
            return contents[PageNumber];
        else
            // 如果 PageNumber 不合理，则返回空字符串
            return string.Empty;
    }

    /// 笔记本中包含的每页的内容
    string[] contents = new[] {
        "这里是序章，我写了很多内容。。。",
        "这里是第 1 页内容。。。",
        "这里是第 2 页内容。。。",
        "这里是第 3 页内容。。。",
        "这里是第 4 页内容。。。",
    };
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 读取并显示可读性内容
void ReadSomething(IReadable something)
{
    while (true)
    {
        // 读取当前页内容，直到没有任何内容可读
        string content = something.GetContent();

        if (string.IsNullOrEmpty(content))
            break;

        // 显示当前页内容，并使页码加 1
        Console.WriteLine(content);
        something.PageNumber++;
    }
}

/// 创建 Note 类的实例，并通过 ReadSomething 显示其内容
Note note = new();
ReadSomething(note);
*/