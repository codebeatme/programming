// 导入命名空间 World.Animal
using World.Animals;

// 创建命名空间 World.Animal 中的 Anemone 类的实例
Anemone anemone1 = new();
anemone1.Run();

// 直接使用命名空间 World.Plant 创建实例
World.Plants.Anemone anemone2 = new();
anemone2.Grow();