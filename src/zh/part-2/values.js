/*
本节文章
https://learnscript.net/zh/programming/part-2/values/ 什么是值
*/

/// '你有一条新的短信' 是一个值
let message = '你有一条新的短信'

/// 表达式 1 + 2，其运算的结果 3 是一个值
let number = 1 + 2

/// 表达式 message，运算的结果是变量 message 包含的值，也就是字符串 '你有一条新的短信'
let message2 = message

/// 表达式 new NewValue() 返回 NewValue 类的实例，这个实例也是一个值
class NewValue { }
let value = new NewValue()
