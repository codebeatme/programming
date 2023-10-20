/*
本節文章
https://learnscript.net/zh-hant/programming/part-4/scope/ 什麽是範圍
*/

// 函式 getBoatName 中定義的變數，在函式外不可見
function getBoatName() {
    const boatName = '飛行荷蘭人'
    return boatName
}

// ERROR boatName 沒有定義
// console.log(`船的名字是？${boatName}`)

// 在函式 showCarName 以外定義了變數 carName
const carName = '四輪馬車'

function showCarName() {
    // 在外部區域定義的變數 carName，對於函式可見
    console.log(`哦？這有一輛叫 ${carName} 的車`)
}

showCarName()