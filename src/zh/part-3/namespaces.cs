/*
本节文章
https://learnscript.net/zh/programming/part-3/namespaces/ 什么是命名空间？命名空间和包有何不同
*/

// 命名空间 World.Animal
namespace World.Animal
{
    // 类 Lion，表示狮子
    class Lion { }
    // 类 Elephant，表示大象
    class Elephant { }
}

// 命名空间 World.Plant
namespace World.Plant
{
    // 类 Shrub，表示灌木
    class Shrub { }
    // 类 Arbor，表示乔木
    class Arbor { }
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// 导入命名空间 World.Animal
using World.Animal;

// 创建命名空间 World.Animal 中的 Lion 类的实例
Lion lion = new();
Console.WriteLine($"这里有一头狮子 {lion}");

// 直接使用命名空间 World.Plant 创建实例
World.Plant.Shrub shrub = new();
Console.WriteLine($"这里有一棵灌木 {shrub}");
*/