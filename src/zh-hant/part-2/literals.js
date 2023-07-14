/*
本節視頻
https://www.bilibili.com/video/BV1xM41157Vx/ 「程式設計指南」什麽是常值？常值和直接值是否相同

常值一般是指，由開發人員直接給出的固定的值，或這些值對應的程式碼文字

版本
Node.js 18.15.0
VSCode 1.77.3

相關視頻
https://www.bilibili.com/video/BV1pN411w7z1/ 什麽是陳述式和運算式？陳述式和運算式的區別
*/

/// '你有一條新的短信' 是常值
let message = '你有一條新的短信'

/// 1 和 2 是常值
let number = 1 + 2

/// message 不是常值
let message2 = message

/// 定義物件的兩種方法
let obj1 = {}
let obj2 = new Object()

/// 單引號，雙引號，反引號都可以表示字串
let str1 = ''
let str2 = ""
let str3 = ``