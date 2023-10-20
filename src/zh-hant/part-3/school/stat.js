/*
本節文章
https://learnscript.net/zh-hant/programming/part-3/modules-and-packages/ 什麽是模組，套件
*/

/// 模組 stat，包含了用於統計的函式

// 學生的數量
exports.studentCount = 100
// 教師的數量
exports.teacherCount = 7

/// 統計學校內的總人數
exports.getPeopleCount = function () {
    return exports.studentCount + exports.teacherCount
}