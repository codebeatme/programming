/*
本节视频
https://www.bilibili.com/video/BV1xM41157Vx/ 「编程指南」什么是字面量？字面量和直接量是否相同

字面量一般是指，由开发人员直接给出的固定的值，或这些值对应的代码文字

版本
Node.js 18.15.0
VSCode 1.77.3

相关视频
https://www.bilibili.com/video/BV1pN411w7z1/ 什么是语句和表达式？语句和表达式的区别

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// '你有一条新的短信' 是字面量
let message = '你有一条新的短信'

/// 1 和 2 是字面量
let number = 1 + 2

/// message 不是字面量
let message2 = message

/// 定义对象的两种方法
let obj1 = {}
let obj2 = new Object()

/// 单引号，双引号，反引号都可以定义字符串
let str1 = ''
let str2 = ""
let str3 = ``