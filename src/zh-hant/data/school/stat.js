// 模組 stat
// 學生的數量
exports.studentCount
// 教師的數量
exports.teacherCount

// 統計學校內的總人數
exports.getPeopleCount = function () {
    return exports.studentCount + exports.teacherCount
}