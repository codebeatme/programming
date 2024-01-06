/*
本节文章
https://learnscript.net/zh/programming/part-1/class-indexers/ 什么是类的索引器
*/

/// 类 Food，表示食物
class Food
{

    /// 字段 _names，表示所有食物的名称
    private string[] _names = new[] {
        "汤", "沙拉", "甜点", "茶"
        };

    /// 索引器，通过整数类型参数获得食物名称
    public string this[int i]
    {
        get { return _names[i]; }
    }

    /// 属性 Count，表示食物种类的数量
    public int Count
    {
        get { return _names.Length; }
    }

    ///
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 创建 Food 的实例
Food food = new();

/// 使用索引器显示所有食物的名称
Console.WriteLine("今天供应以下食物：");

for (int i = 0; i < food.Count; i++)
    Console.WriteLine($"\t{food[i]}");
*/