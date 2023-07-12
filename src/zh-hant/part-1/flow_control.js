/*
本節視頻
https://www.bilibili.com/video/BV1CM4y1172a/ 「程式設計指南」什麽是流程控製？什麽是條件控製和迴圈控製

本節文章
https://learnscript.net/zh-hant/programming/part-1/flow-control-conditions-loops/ 什麽是流程控製，條件，迴圈控製
*/

/// 條件控製
// TODO 需要編寫獲取用戶年齡的程式碼
let age = get_user_age()
// 如果 age 超出 0 到 100，則將 age 設定為 0
if (age < 0 || age > 100)
    age = 0

/// 迴圈控製
// TODO 需要編寫獲取用戶薪水的程式碼
let money = get_user_money()
// money 反覆減 1，直到 money 小於等於 0
while (money > 0)
    money -= 1

/// for 迴圈周遊陣列
for (let x of ['a', 'b', 'c'])
    console.log(x)