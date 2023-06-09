/*
本节视频
https://www.bilibili.com/video/BV1Yv4y1H7BR/ 「编程指南」什么是运算符？运算符的分类和优先级

本节文章
https://learnscript.net/zh/programming/part-1/operators/ 什么是运算符？运算符的分类和优先级
*/

/// 不同种类的运算符
// 赋值运算符，= 将 age 赋值为 50
let age = 50
// 比较运算符，== 比较 age 是否等于 100
if (age == 100);
// 逻辑运算符，&& 表示两边的条件需要同时成立
if (age > 0 && age < 100);
// 算术运算符，- 将 100 和 10 进行减法计算
age = 100 - 10

/// 运算符具有优先级
// 这里先计算乘法，后计算加法，num 将被赋值为 7
let num = 1 + 2 * 3