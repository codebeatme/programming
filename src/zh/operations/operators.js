// == 允许数据类型隐式转换，表达式结果为 true
console.log(1 == '1')
// == 不允许数据类型隐式转换，表达式结果为 false
console.log(1 === '1')

// 'A' 和 'B' 都会被计算
console.log('A' && 'B')
// 'A' 会被计算 ，'B' 将被丢弃
console.log('A' || 'B')

// 四个作为操作数的函数
a = () => {
    console.log('a')
    return 1
}
b = () => {
    console.log('b')
    return 2
}
c = () => {
    console.log('c')
    return 3
}
d = () => {
    console.log('d')
    return 4
}

// b() 和 c() 并不会被优先计算
const result = a() / (b() + c()) * d()
console.log(result)