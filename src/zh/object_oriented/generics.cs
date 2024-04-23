// 类 Box，表示存储内容的箱子
class Box
{
    // 字段 items，一个简单的数组
    object[] items;

    // 构造器，可以初始化 items
    public Box(params object[] i)
    {
        items = i ?? Array.Empty<object>();
    }

    // 泛型方法 GetFirst，获取数组中第一个类型为 T 的元素
    // public T? GetFirst<T>()
    public T? GetFirst<T>() where T : class
    {
        // 如果元素的类型与 T 一致，则返回
        foreach (object item in items)
            if (item.GetType() == typeof(T))
                return (T)item;

        return default;
    }
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// 类型参数 T 被指定为 string
List<string> nicknames = new();

// 创建 Box 的实例 box
Box box = new("第一个字符串", 123, "第二个字符串", 234, 0.123f, 0.234f);
// 获取 box 中的第一个字符串
Console.WriteLine(box.GetFirst<string>());
// 获取 box 中的第一个整数
Console.WriteLine(box.GetFirst<int>());
// 获取 box 中的第一个浮点数
Console.WriteLine(box.GetFirst<float>());
*/