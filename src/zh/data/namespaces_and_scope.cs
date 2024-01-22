// 类 Flower，表示一朵花
class Flower
{
    // 嵌套类型 Color
    enum Color
    {
        // 没有颜色
        None = 0,
        // 红色
        Red = 1,
        // 白色
        White = 2,
        // 蓝色
        Blue = 3,
    }

    // 字段 Color，表示花的颜色，随机产生
    private Color color = (Color)new Random().Next(1, 4);
    // …
}

// 命名空间 World.Animals
namespace World.Animals
{
	// 类 Lion，表示狮子
	class Lion { }
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// 变量 total，用于保存计算结果
int total = 0;

// 函数 sum，进行加法计算
void sum(int num) {
    // 函数内可以访问函数外的变量 total
    total += num;
}

// 调用 sum
sum(7);
sum(9);

Console.WriteLine($"结果为：{total}");
*/