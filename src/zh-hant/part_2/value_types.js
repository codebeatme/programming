/*
本節文章
https://learnscript.net/zh-hant/programming/part-2/value-and-reference-types/ 什麽是實值型別，參考型別？有何不同
*/

/// 實值型別變數在讀取或寫入值時，互不影響
let message1 = '今天天氣不錯'
// 讀取 message1 的值，將該值寫入 message2
let message2 = message1

/// 為 message1 寫入新值，不會影響 message2
message1 = '今天天氣很糟糕'
// 顯示變數 message2，以觀察其值是否發生了變化
console.log(`message2=${message2}`)