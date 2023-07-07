/*
本节视频
https://www.bilibili.com/video/BV1HM4y1a71U/ 「编程指南」什么是类的索引？类的索引的作用

类的索引，可以让类像数组一样被访问
* 索引需要指定一个参数，以区分需要返回的具体内容

版本
.NET 7.0.2
VSCode 1.77.3

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// 类 Food，表示食物
class Food
{

    /// 字段 _names，表示所有食物的名称
    private string[] _names = new[] {
        "汤", "沙拉", "甜点", "茶"
        };

    /// 索引，通过整型参数获得食物名称
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
Food food = new Food();

/// 使用索引显示所有食物的名称
Console.WriteLine($"今天供应以下食物：");

for (int i = 0; i < food.Count; i++)
    Console.WriteLine($"\t{food[i]}");
*/