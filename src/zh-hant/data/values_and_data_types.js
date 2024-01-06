// '你有一條新的短信' 是常值
let message = '你有一條新的短信'
// 1 是常值
let number = 1
// message 不是常值，因為他表示的不是固定值
let message2 = message

// Date.now() 是運算式
let timestamp = Date.now()
// 顯示當前時間戳記
console.log(`當前時間戳記：${timestamp}`)

// 顯示 null 值
console.log(null)

// 1 會隱含轉換為 '1'
console.log(1 + '2')