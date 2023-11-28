/*
本节文章
https://learnscript.net/zh/programming/part-2/value-and-reference-types/ 什么是值类型，引用类型？有何不同
*/

/// 类 Cup，表示了一个茶杯
class Cup {
    name = '大茶杯'
    price = 10
}

/// 引用类型变量，将保持对实例的引用
let cup1 = new Cup()
// cup2 和 cup1 会引用同一个实例
let cup2 = cup1

/// 无论通过 cup1，还是 cup2 修改或显示字段都是一样的
cup1.name = '小茶杯'
cup1.price = 5
console.log(`${cup2.name} 价格为 ${cup2.price}`)