/*
本节文章
https://learnscript.net/zh/programming/part-3/modules-and-packages/ 什么是模块，包
*/

/// 模块 stat，包含了用于统计的函数

// 学生的数量
exports.studentCount = 100
// 教师的数量
exports.teacherCount = 7

/// 统计学校内的总人数
exports.getPeopleCount = function () {
    return exports.studentCount + exports.teacherCount
}