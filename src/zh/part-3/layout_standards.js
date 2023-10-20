/*
本节文章
https://learnscript.net/zh/programming/part-3/layout-standards/ 什么是布局规范
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