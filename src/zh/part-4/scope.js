/*
本节文章
https://learnscript.net/zh/programming/part-4/scope/ 什么是作用域
*/

// 函数 getBoatName 中定义的变量，在函数外不可见
function getBoatName() {
    const boatName = '飞行荷兰人'
    return boatName
}

// ERROR boatName 没有定义
// console.log(`船的名字是？${boatName}`)

// 在函数 showCarName 以外定义了变量 carName
const carName = '四轮马车'

function showCarName() {
    // 在外部区域定义的变量 carName，对于函数可见
    console.log(`哦？这有一辆叫 ${carName} 的车`)
}

showCarName()