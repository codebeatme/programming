/*
本节视频
https://www.bilibili.com/video/BV1Ag4y1L79v/ 「编程指南」什么是常量？什么是编译时常量和运行时常量？编译时和运行时常量的区别

常量是指不能被改变的量，可被分为编译时常量和运行时常量
* 编译时常量的值，需要在编译时即可被确定
* 在编译时，编译时常量将被替换为其值的字面量
* 运行时常量的值，不必在编译时被确定

版本
.NET 7.0.2
Node.js 18.16.0
VSCode 1.78.1

相关视频
https://www.bilibili.com/video/BV1rz4y187ny/ 什么是编译？什么是编译时和运行时
https://www.bilibili.com/video/BV1xM41157Vx/ 什么是字面量？字面量和直接量是否相同
https://www.bilibili.com/video/BV1yM411N7Ti/ 什么是变量

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

for (let x = 0; x < 3; x++)
    for (let y = 0; y < 3; y++) {
        /// 运行时常量，其值可以在运行时确定
        const result = x * y

        console.log(result)
    }

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 通过字面量为常量赋值
const int A1 = 13;

/// A1 是常量，所以表达式可以在编译时计算出结果
const int A2 = 13 + A1;

/// 常量 A3 的值不能在编译时被确定，因为 b1 的值在编译时是无法确定的
int b1 = 0;
const int A3 = b1;

/// A1 处被替换为 13，A2 处被替换为 26
Console.WriteLine($"{A1} {A2}");
*/