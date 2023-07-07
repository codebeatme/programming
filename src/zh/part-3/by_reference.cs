/*
本节视频
https://www.bilibili.com/video/BV1im4y1h7gK/ 「编程指南」什么是引用传递和值传递？引用传递和值传递的区别，引用传递的扩展

引用传递和值传递是两种不同的，变量存储地址的分配策略
* 引用传递可以使多个变量在栈中存储数据的地址保持一致
* 值传递会使变量在栈中存储数据的地址保持不同
* 本节中的数据一词，特指值和值的引用

版本
.NET 7.0.2
VSCode 1.78.2

相关视频
https://www.bilibili.com/video/BV1vk4y1j7Eo/ 什么是堆和栈？堆和栈在存储值时的区别
https://www.bilibili.com/video/BV1cM411G7VC/ 什么是值类型变量？什么是引用型变量？有什么区别

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

class Fruit
{
    public override string ToString()
    {
        return "我是水果！";
    }
}

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
Fruit fruit1 = new Fruit();
Fruit fruit2 = fruit1;

// 对 fruit2 赋值，fruit1 不受影响
fruit2 = new Orange();

Console.WriteLine($"fruit1={fruit1}");
Console.WriteLine($"fruit2={fruit2}");
*/