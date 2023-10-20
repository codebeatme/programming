/*
本节文章
https://learnscript.net/zh/programming/part-3/passing-by-value-and-reference/ 什么是值传递，引用传递？有何不同
*/

// 类 Fruit，表示水果
class Fruit
{
    public override string ToString()
    {
        return "我是水果！";
    }
}

// 类 Orange，表示橙子
class Orange : Fruit
{
    public override string ToString()
    {
        return "这是一个橙子！";
    }
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 引用传递
unsafe
{
    int num1 = 100;
    ref int num2 = ref num1;

    // num1，num2 在栈中存储数据的地址一样
    Console.WriteLine($"num1 用来存储值的地址为：{(int)&num1:x}");
    fixed (int* pnum2 = &num2)
        Console.WriteLine($"num2 用来存储值的地址为：{(int)pnum2:x}");

    // 对 num2 赋值，等同于对 num1 赋值
    num2 = 200;
    Console.WriteLine($"num1={num1}");
}

/// 值传递
// num1，num2 在栈中存储数据的地址不同
Fruit fruit1 = new();
Fruit fruit2 = fruit1;

// 对 fruit2 赋值，fruit1 不受影响
fruit2 = new Orange();

Console.WriteLine($"fruit1={fruit1}");
Console.WriteLine($"fruit2={fruit2}");
*/