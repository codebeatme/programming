/*
本節文章
https://learnscript.net/zh-hant/programming/part-3/namespaces/ 什麽是命名空間？命名空間和套件有何不同
*/

// 命名空間 World.Animal
namespace World.Animal
{
    // 類別 Lion，表示獅子
    class Lion { }
    // 類別 Elephant，表示大象
    class Elephant { }
}

// 命名空間 World.Plant
namespace World.Plant
{
    // 類別 Shrub，表示灌木
    class Shrub { }
    // 類別 Arbor，表示喬木
    class Arbor { }
}

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

// 匯入命名空間 World.Animal
using World.Animal;

// 建立命名空間 World.Animal 中的 Lion 類別的執行個體
Lion lion = new();
Console.WriteLine($"這裏有一頭獅子 {lion}");

// 直接使用命名空間 World.Plant 建立執行個體
World.Plant.Shrub shrub = new();
Console.WriteLine($"這裏有一棵灌木 {shrub}");
*/