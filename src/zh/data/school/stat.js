// 模块 stat
// 学生的数量
exports.studentCount
// 教师的数量
exports.teacherCount

// 统计学校内的总人数
exports.getPeopleCount = function () {
    return exports.studentCount + exports.teacherCount
}