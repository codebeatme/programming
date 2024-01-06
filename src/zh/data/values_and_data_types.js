// '你有一条新的短信' 是字面量
let message = '你有一条新的短信'
// 1 是字面量
let number = 1
// message 不是字面量，因为他表示的不是固定值
let message2 = message

// Date.now() 是表达式
let timestamp = Date.now()
// 显示当前时间戳
console.log(`当前时间戳：${timestamp}`)

// 显示 null 值
console.log(null)

// 1 会隐式转换为 '1'
console.log(1 + '2')