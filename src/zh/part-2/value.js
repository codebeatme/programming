/*
本节视频
https://www.bilibili.com/video/BV1wP411U7i4/ 「编程指南」什么是值？值和表达式的关系

值可以理解为数据和信息的具体内容，也可以认为是表达式返回的运算结果

版本
Node.js 18.15.0
VSCode 1.77.3

相关视频
https://www.bilibili.com/video/BV1pN411w7z1/ 什么是语句和表达式？语句和表达式的区别
https://www.bilibili.com/video/BV1bo4y1879U/ 什么是类？什么是对象和实例？类和对象实例的区别

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// '你有一条新的短信' 是一个值
let message = '你有一条新的短信'

/// 表达式 1 + 2，其运算的结果 3 是一个值
let number = 1 + 2

/// 表达式 message，运算的结果是变量 message 包含的值，也就是字符串 '你有一条新的短信'
let message2 = message

/// 表达式 new NewValue() 返回 NewValue 类的实例，这个实例也是一个值
class NewValue {}
let value = new NewValue()
