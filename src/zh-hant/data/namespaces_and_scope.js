/*
本節文章
https://learnscript.net/zh-hant/programming/part-3/modules-and-packages/ 什麽是模組，套件
*/

// 匯入模組 stat
const stat = require('./school/stat')

// 設定學校人數
stat.studentCount = 100
stat.teacherCount = 10

// 呼叫模組的 getPeopleCount 函式，取得學校內的總人數
console.log(`學校內的總人數為：${stat.getPeopleCount()}`)