/*
本節文章
https://learnscript.net/zh-hant/programming/part-3/namespaces/ 什麽是命名空間？命名空間和套件有何不同
*/

// 命名空間 World.Animals
namespace World.Animals
{
    // 類別 Lion，表示獅子
    class Lion { }
    // 類別 Anemone，表示海葵
    class Anemone
    {
        // 方法 Run，用於奔跑
        public void Run()
        {
            Console.WriteLine("海葵奔跑起來了");
        }
    }
}

// 命名空間 World.Plants
namespace World.Plants
{
    // 類別 Shrub，表示灌木
    class Shrub { }
    // 類別 Anemone，表示海葵
    class Anemone
    {
        // 方法 Grow，用於生長
        public void Grow()
        {
            Console.WriteLine("海葵開始生長了");
        }
    }
}

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

// 匯入命名空間 World.Animals
using World.Animals;

// 建立命名空間 World.Animals 中的 Anemone 類別的執行個體
Anemone anemone1 = new();
anemone1.Run();

// 使用完整名稱 World.Plants.Anemone 建立執行個體
World.Plants.Anemone anemone2 = new();
anemone2.Grow();
*/