let odd = 0
let i = 0

// 將 1 至 100 的奇數相加，當和大於 100 時跳出
while (true) {
    // 如果是偶數，則跳出本次迴圈
    if (++i % 2 == 0)
        continue

    odd += i

    // 如果和大於 100，則跳出整個迴圈
    if (odd > 100)
        break
}

console.log(`奇數之和為：${odd}`)

// 產生一個隨機亂數
const number = Math.random()

// 分支結構，根據數值顯示資訊
if (number < 0.5)
    console.log('數值小於 0.5')
else if (number > 0.5)
    console.log('數值大於 0.5')
else
    console.log('神奇的數值')

let even = 0

// 使用迴圈結構計算 1 至 100 所有偶數的和
for (let i = 1; i <= 100; i++)
    if (i % 2 == 0)
        even += i

console.log(`偶數之和為：${even}`)