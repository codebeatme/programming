/*
本节视频
https://www.bilibili.com/video/BV14h4y1b7Sp/ 「编程指南」什么是类型转换？什么隐式转换和显式转换？引用型变量的类型转换

当进行某种形式的赋值时，如果值的数据类型与预期的数据类型不同时，就会发生或需要进行类型转换
* 如果转换不会导致信息丢失或改变，则会进行隐式转换
* 否则，需要进行显式转换
* 对于引用型变量，所谓的类型转换，更像是一种安全性的声明

版本
.NET 7.0.2
VSCode 1.78.0

相关视频
https://www.bilibili.com/video/BV1cM411G7VC/ 什么是值类型变量？什么是引用型变量？有什么区别
https://www.bilibili.com/video/BV1Dm4y1B7gi/ 什么是数据类型？数字类型和字符串类型的区别

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

class Plant { }

class Tree : Plant { }

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 隐式转换
int small1 = 200;

// 长整型可以表示，所有整型可以表示的数字
long big1 = small1;

/// 显示转换
long big2 = 100000000000000;

// 整型不能完全表示，长整型可以表示的数字，信息可能丢失或改变
int small2 = (int)big2;
Console.WriteLine(small2 == big2);

///
Tree t1 = new Tree();
Plant p = t1;
Tree t2 = (Tree)p;
*/