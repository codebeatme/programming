// 定義變數 age，他將獲得預設值 undefined
let age
// 顯示變數 age 的值
console.log(age)

// // ERROR 變數 student 沒有被定義過，這會導致例外狀況
// console.log(student)

// 一個將資訊發送給客戶的函式
function sendToClient(message) {
    console.log(`發送給客戶：${message}`)
}

// 將函式 sendToClient 指派給變數 fn
let fn = sendToClient
// 通過變數呼叫函式
fn('今天天氣不錯！')

for (let x = 0; x < 2; x++)
    for (let y = 0; y < 2; y++) {
        /// 執行階段常數，其值在執行階段確定
        const result = x * y

        console.log(result)
    }