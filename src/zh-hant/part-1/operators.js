/*
本節文章
https://learnscript.net/zh-hant/programming/part-1/operators/ 什麽是運算子？運算子的分類和優先順序
*/

/// 不同種類的運算子
// 指派運算子，= 將 age 指派為 50
let age = 50
// 比較運算子，== 比較 age 是否等於 100
if (age == 100);
// 邏輯運算子，&& 表示兩邊的條件需要同時成立
if (age > 0 && age < 100);
// 算術運算子，- 將 100 和 10 進行減法計算
age = 100 - 10

/// 運算子具有優先順序
// 這裏先計算乘法，後計算加法，num 將被指派為 7
let num = 1 + 2 * 3