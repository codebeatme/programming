/*
本节视频
https://www.bilibili.com/video/BV1uo4y1V7zS/ 「编程指南」什么是布局规范？布局的一般原则

布局规范主要用于，保持代码的良好空间感，以轻松的阅读和维护他们
* 使用空白行，分区功能不同的代码块
* 使用空格提高表达式的可读性
* 使用缩进来展示代码的层次
* 将一行很长的代码转换为多行

版本
Node.js 18.16.0
VSCode 1.78.0

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// 空白行区分变量定义和函数
var message = '你好；也许是的；或者不是'


function what() { }

/// 表达式中加入空格，提高可读性
let result = 100 + 1 / 20 * 32

/// 使用缩进展现代码的层次
for (let i = 0; i < 1000; i++)
    if (i < result)
        console.log(i)

/// 将一行过长的代码，转换为多行
let array = [
    '这是一行非常非常非常长的代码',
    '哦？！是吗？',
    '大概是吧！'
]

/// 自动格式化
let age = 2023 - getBirthYear()
if (age < 30)
    console.log('哦！一个年龄小于30的人！')