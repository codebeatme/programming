// 回调函数 message，显示一条消息
function message() {
    console.log('一条消息？！')
}

// 函数 setTimeout 将在 3 秒后调用 message
setTimeout(message, 3000)
// console.log 会紧接着 setTimeout 执行
console.log('请等待 3 秒钟！')
