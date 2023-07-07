/*
本节视频
https://www.bilibili.com/video/BV1vk4y1j7Eo/ 「编程指南」什么是堆和栈？堆和栈在存储值时的区别

堆和栈是两种存储数据的方案，需要与数据结构中的堆和栈进行区别
* 值类型变量保持的值，被存储在栈中
* 引用型变量保持了值的引用，这个引用被存储在栈中，而被引用的值则存储在堆中

版本
Node.js 18.16.0
VSCode 1.78.0

相关视频
https://www.bilibili.com/video/BV1cM411G7VC/ 什么是值类型变量？什么是引用型变量？有什么区别

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// 100 将被存储在栈中
let number = 100

/// 被创建的 Apple 对象将存储在堆中
let apple = new Apple()

// 苹果类
class Apple { }