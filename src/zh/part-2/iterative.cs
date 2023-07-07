/*
本节视频
https://www.bilibili.com/video/BV1aa4y1G7jj/ 「编程指南」什么是迭代？迭代的作用

迭代提供了遍历元素的功能
* 你可以访问当前位置的元素
* 或前进到下一个元素的位置

版本
.NET 7.0.2
VSCode 1.78.0

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// 表示姓名的类，实现了迭代功能
class MyName : System.Collections.IEnumerator
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

/// 创建 MyName 的实例，并设置名，中间名和姓
MyName name = new MyName(){
    FirstName = "汤姆",
    SecondName = "彼得",
    LastName = "史密斯"
};

/// 显示 MyName 包含的三个元素，名，中间名和姓
while(name.MoveNext())
    Console.WriteLine(name.Current);
*/