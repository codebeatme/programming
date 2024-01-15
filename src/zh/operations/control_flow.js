let odd = 0
let i = 0

// 将 1 至 100 的奇数相加，当和大于 100 时跳出
while (true) {
    // 如果是偶数，则跳出本次循环
    if (++i % 2 == 0)
        continue

    odd += i

    // 如果和大于 100，则跳出整个循环
    if (odd > 100)
        break
}

console.log(`奇数之和为：${odd}`)

// 产生一个随机数
const number = Math.random()

// 分支结构，根据数字显示信息
if (number < 0.5)
    console.log('数字小于 0.5')
else if (number > 0.5)
    console.log('数字大于 0.5')
else
    console.log('神奇的数字')

let even = 0

// 使用循环结构计算 1 至 100 所有偶数的和
for (let i = 1; i <= 100; i++)
    if (i % 2 == 0)
        even += i

console.log(`偶数之和为：${even}`)