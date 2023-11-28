/*
本节文章
https://learnscript.net/zh/programming/part-3/namespaces/ 什么是命名空间？命名空间和包有何不同
*/

// 命名空间 World.Animals
namespace World.Animals
{
    // 类 Lion，表示狮子
    class Lion { }
    // 类 Anemone，表示海葵
    class Anemone
    {
        // 方法 Run，用于奔跑
        public void Run()
        {
            Console.WriteLine("海葵奔跑起来了");
        }
    }
}

// 命名空间 World.Plants
namespace World.Plants
{
    // 类 Shrub，表示灌木
    class Shrub { }
    // 类 Anemone，表示海葵
    class Anemone
    {
        // 方法 Grow，用于生长
        public void Grow()
        {
            Console.WriteLine("海葵开始生长了");
        }
    }
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// 导入命名空间 World.Animals
using World.Animals;

// 创建命名空间 World.Animals 中的 Anemone 类的实例
Anemone anemone1 = new();
anemone1.Run();

// 使用完全限定名 World.Plants.Anemone 创建实例
World.Plants.Anemone anemone2 = new();
anemone2.Grow();
*/