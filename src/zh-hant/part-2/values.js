/*
本節視頻
https://www.bilibili.com/video/BV1wP411U7i4/ 「程式設計指南」什麽是值？值和運算式的關系

值可以理解為資料和資訊的具體內容，也可以認為是運算式傳回的運算結果

版本
Node.js 18.15.0
VSCode 1.77.3

相關視頻
https://www.bilibili.com/video/BV1pN411w7z1/ 什麽是陳述式和運算式？陳述式和運算式的區別
https://www.bilibili.com/video/BV1bo4y1879U/ 什麽是類別？什麽是物件和執行個體？類別和物件執行個體的區別

關於本系列教程的使用說明和相關問題解答，請參考文章 https://www.bilibili.com/read/cv23041317
*/

/// '你有一條新的短信' 是一個值
let message = '你有一條新的短信'

/// 運算式 1 + 2，其運算的結果 3 是一個值
let number = 1 + 2

/// 運算式 message，運算的結果是變數 message 包含的值，也就是字串 '你有一條新的短信'
let message2 = message

/// 運算式 new NewValue() 傳回 NewValue 類別的執行個體，這個執行個體也是一個值
class NewValue {}
let value = new NewValue()
