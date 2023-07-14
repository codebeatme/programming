/*
本节视频
https://www.bilibili.com/video/BV1cM411G7VC/ 「编程指南」什么是值类型变量？什么是引用型变量？有什么区别

直接存储值的变量被称为值类型变量，保持对值的引用的变量被称为引用型变量
* 值类型变量所存储的值，与其他变量没有关系
* 引用型变量可能会对同一个值进行访问和操作

版本
Node.js 18.15.0
VSCode 1.77.3

相关视频
https://www.bilibili.com/video/BV1yM411N7Ti/ 什么是变量
https://www.bilibili.com/video/BV1bo4y1879U/ 什么是类？什么是对象和实例？类和对象实例的区别
https://www.bilibili.com/video/BV1vk4y1j7Eo/ 什么是堆和栈？堆和栈在存储值时的区别

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// 类 Cup
class Cup {
    name = '大茶杯'
    price = 10
}

/// 引用型变量，将保持对实例的引用
let cup1 = new Cup()
// cup2 和 cup1 会引用同一个实例
let cup2 = cup1

/// 无论通过 cup1，还是 cup2 修改或显示字段都是一样的
cup1.name = '小茶杯'
cup1.price = 5
console.log(`${cup2.name} 价格为 ${cup2.price}`)