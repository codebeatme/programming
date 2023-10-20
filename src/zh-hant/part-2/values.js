/*
本節文章
https://learnscript.net/zh-hant/programming/part-2/values/ 什麽是值
*/

/// '你有一條新的短信' 是一個值
let message = '你有一條新的短信'

/// 運算式 1 + 2，其運算的結果 3 是一個值
let number = 1 + 2

/// 運算式 message，運算的結果是變數 message 包含的值，也就是字串 '你有一條新的短信'
let message2 = message

/// 運算式 new NewValue() 傳回 NewValue 類別的執行個體，這個執行個體也是一個值
class NewValue { }
let value = new NewValue()
