// 回呼函式 message，顯示一條訊息
function message() {
    console.log('一條訊息？！')
}

// 函式 setTimeout 將在 3 秒後呼叫 message
setTimeout(message, 3000)
// console.log 會緊接著 setTimeout 執行
console.log('請等待 3 秒鐘！')
