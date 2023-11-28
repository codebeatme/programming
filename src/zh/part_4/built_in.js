/*
本节文章
https://learnscript.net/zh/programming/part-4/built-in/ 什么是内置
*/

// 使用内置类 Array 保存随机数
const nums = new Array()

// 使用内置类 Math 生成 5 个随机数，并保存到数组中
for (let i = 0; i < 5; i++)
    nums.push(Math.floor(Math.random() * 10))

// 显示数组中小于 7 的随机数
nums.forEach(i => {
    if (i < 7)
        console.log(`随机数：${i}`)
})