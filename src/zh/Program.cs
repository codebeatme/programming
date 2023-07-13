/// 创建 Food 的实例
Food food = new Food();

/// 使用索引显示所有食物的名称
Console.WriteLine($"今天供应以下食物：");

for (int i = 0; i < food.Count; i++)
    Console.WriteLine($"\t{food[i]}");
