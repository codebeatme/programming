// 定义变量 age，他将获得默认值 undefined
let age
// 显示变量 age 的值
console.log(age)

// // ERROR 变量 student 没有被定义过，这会导致异常
// console.log(student)

// 一个将信息发送给客户的函数
function sendToClient(message) {
    console.log(`发送给客户：${message}`)
}

// 将函数 sendToClient 赋值给变量 fn
let fn = sendToClient
// 通过变量调用函数
fn('今天天气不错！')

for (let x = 0; x < 2; x++)
    for (let y = 0; y < 2; y++) {
        /// 运行时常量，其值在运行时确定
        const result = x * y

        console.log(result)
    }