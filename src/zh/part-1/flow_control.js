/*
本节文章
https://learnscript.net/zh/programming/part-1/flow-control-conditions-loops/ 什么是流程控制，条件，循环控制
*/

/// 条件控制
// TODO 需要编写获取用户年龄的代码
let age = get_user_age()
// 如果 age 超出 0 到 100，则将 age 设置为 0
if (age < 0 || age > 100)
    age = 0

/// 循环控制
// TODO 需要编写获取用户薪水的代码
let money = get_user_money()
// money 反复减 1，直到 money 小于等于 0
while (money > 0)
    money -= 1

/// for 循环遍历数组
for (let x of ['a', 'b', 'c'])
    console.log(x)