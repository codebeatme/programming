/*
本节文章
https://learnscript.net/zh/programming/part-2/value-and-reference-types/ 什么是值类型，引用类型？有何不同
*/

/// 值类型变量在读取或写入值时，互不影响
let message1 = '今天天气不错'
// 读取 message1 的值，将该值写入 message2
let message2 = message1

/// 为 message1 写入新值，不会影响 message2
message1 = '今天天气很糟糕'
// 显示变量 message2，以观察其值是否发生了变化
console.log(`message2=${message2}`)