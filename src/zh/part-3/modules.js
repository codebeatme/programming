/*
本节文章
https://learnscript.net/zh/programming/part-3/modules-and-packages/ 什么是模块，包
*/

/// 导入模块 stat
const stat = require('./school/stat')

/// 调用模块的 getPeopleCount 函数，获取学校内的总人数
console.log(`学校内的总人数为：${stat.getPeopleCount()}`)