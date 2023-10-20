/*
本節文章
https://learnscript.net/zh-hant/programming/part-3/compile-and-run-time-constants/ 什麽是編譯時，執行時常數？有何不同
*/

for (let x = 0; x < 3; x++)
    for (let y = 0; y < 3; y++) {
        /// 執行時常數，其值可以在執行時確定
        const result = x * y

        console.log(result)
    }
