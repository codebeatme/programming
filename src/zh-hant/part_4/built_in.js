/*
本節文章
https://learnscript.net/zh-hant/programming/part-4/built-in/ 什麽是內建
*/

// 使用內建類別 Array 儲存隨機亂數
const nums = new Array()

// 使用內建類別 Math 產生 5 個隨機亂數，並儲存到陣列中
for (let i = 0; i < 5; i++)
    nums.push(Math.floor(Math.random() * 10))

// 顯示陣列中小於 7 的隨機亂數
nums.forEach(i => {
    if (i < 7)
        console.log(`隨機亂數：${i}`)
})