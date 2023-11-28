/*
本节文章
https://learnscript.net/zh/programming/part-3/variadic-parameters/ 什么是可变参数
*/

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 显示一组水果信息的函数
void ListFruit(
    // list 是一个可变参数
    params Fruit[] list
    )
{
    Console.WriteLine($"一共有 {list.Length} 个水果");

    foreach (Fruit fruit in list)
        Console.WriteLine(fruit);
}

/// 可以为 ListFruit 指定多个 Fruit 和其派生类的实例
ListFruit(
    new Fruit(),
    new Orange(),
    new Orange(),
    new Fruit()
);
*/