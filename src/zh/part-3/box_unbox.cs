/*
本节视频
https://www.bilibili.com/video/BV11a4y137MU/ 「编程指南」什么是装箱和拆箱？出现装箱和拆箱的原因

装箱和拆箱，可以被理解为一种特殊的类型转换过程或操作
* 装箱是根据栈中的值，产生一个等效的，存储在堆中的值
* 拆箱是根据堆中的值，产生一个等效的，存储在栈中的值

版本
.NET 7.0.2
VSCode 1.78.1

相关视频
https://www.bilibili.com/video/BV14h4y1b7Sp/ 什么是类型转换？什么隐式转换和显式转换？引用型变量的类型转换
https://www.bilibili.com/video/BV1vk4y1j7Eo/ 什么是堆和栈？堆和栈在存储值时的区别

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// 变量 number 的值 1000，被存储在栈中
int number = 1000;

// 方法的参数类型为 object，与 number 的类型不同
void printSomething(object something)
{
    if (something is int) {
        // 根据堆中的 object 对象，产生一个等效的整型值，并存储在栈中
        int n = (int)something;
        Console.WriteLine($"他是数字 {n}");
    }
}

// 将根据 1000 产生等效的 object 对象，并存储在堆中
printSomething(number);
*/