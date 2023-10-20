/*
本節文章
https://learnscript.net/zh-hant/programming/part-3/layout-standards/ 什麽是布局規格
*/

/// 空白行區分變數定義和函式
var message = '你好；也許是的；或者不是'


function what() { }

/// 運算式中加入空格，提高可讀性
let result = 100 + 1 / 20 * 32

/// 使用縮排展現程式碼的層次
for (let i = 0; i < 1000; i++)
    if (i < result)
        console.log(i)

/// 將一行過長的程式碼，轉換為多行
let array = [
    '這是一行非常非常非常長的程式碼',
    '哦？！是嗎？',
    '大概是吧！'
]

/// 自動格式化
let age = 2023 - getBirthYear()
if (age < 30)
    console.log('哦！一個年齡小於30的人！')