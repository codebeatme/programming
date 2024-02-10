// == 允許資料型別隱含轉換，運算式結果為 true
console.log(1 == '1')
// == 不允許資料型別隱含轉換，運算式結果為 false
console.log(1 === '1')

// 'A' 和 'B' 都會被計算
console.log('A' && 'B')
// 'A' 會被計算 ，'B' 將被丟棄
console.log('A' || 'B')

// 四個作為運算元的函式
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

// b() 和 c() 並不會被優先計算
const result = a() / (b() + c()) * d()
console.log(result)