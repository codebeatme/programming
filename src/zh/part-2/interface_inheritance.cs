/*
本节文章
https://learnscript.net/zh/programming/part-2/interface-inheritance-base-and-derived-interfaces/ 什么是接口的继承，基接口，派生接口
*/

/*
// 以下代码与 interfaces.cs 只能有一个不被注释

/// 接口 IReadable，表示可读性
interface IReadable
{
    // 当前的页码
    int PageNumber { get; set; }
    // 获取当前页的内容
    string GetContent();
}

/// 接口 IEditable，继承自 IReadable，表示可编辑
interface IEditable : IReadable
{
    // 设置某一页的内容
    void SetContent(int pageNumber, string content);
}

/// 类 Note，实现了接口 IEditable
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
    string[] contents = new[] {
        "这里是序章，我写了很多内容。。。",
        "这里是第 1 页内容。。。",
        "这里是第 2 页内容。。。",
        "这里是第 3 页内容。。。",
        "这里是第 4 页内容。。。",
    };
}
*/

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

/// 通过接口来使用 Note 类
IEditable edit = new Note();
// 修改序章的内容
edit.SetContent(0, "我又修改了一下序章的内容。。。");
// 显示所有页的内容
ReadSomething(edit);
*/