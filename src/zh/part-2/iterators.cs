/*
本节文章
https://learnscript.net/zh/programming/part-2/iterators/ 什么是迭代器
*/

/// 类 Name，表示姓名，实现了迭代器功能
class Name : System.Collections.IEnumerator
{
    /// 一个人的全名，依次为名，中间名，姓
    public string FirstName = "<默认名>";
    public string SecondName = "<默认中间名>";
    public string LastName = "<默认姓>";

    /// 当前位置
    private int position = -1;

    /// 获取当前位置的元素的内容，可能是名，中间名或姓
    public object Current
    {
        get
        {
            if (position == 0)
                return FirstName;
            else if (position == 1)
                return SecondName;
            else if (position == 2)
                return LastName;
            else
                return string.Empty;
        }
    }

    /// 进入下一个元素的位置
    public bool MoveNext()
    {
        position++;

        // 已经是最后的元素
        if (position > 2)
            return false;

        return true;
    }

    /// 重置位置
    public void Reset()
    {
        position = -1;
    }

    ///
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 创建 Name 的实例，并设置名，中间名和姓
Name name = new()
{
    FirstName = "汤姆",
    SecondName = "彼得",
    LastName = "史密斯"
};

/// 显示 Name 包含的三个元素，名，中间名和姓
while (name.MoveNext())
    Console.WriteLine(name.Current);
*/