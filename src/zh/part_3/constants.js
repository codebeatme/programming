/*
本节文章
https://learnscript.net/zh/programming/part-3/compile-and-run-time-constants/ 什么是编译时，运行时常量？有何不同
*/

for (let x = 0; x < 3; x++)
    for (let y = 0; y < 3; y++) {
        /// 运行时常量，其值可以在运行时确定
        const result = x * y

        console.log(result)
    }
