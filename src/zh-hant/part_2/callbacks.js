// 類別 Person，表示某個人
class Person {
    constructor(name, age) {
        // 欄位姓名和年齡
        this.name = name
        this.age = age
    }
}

// 通過向 main 函式傳遞不同的回呼目標，可以改變 main 函式的功能
function main(callback) {
    const tom = new Person('湯姆', 7)

    // 將 Person 類別的執行個體作為參數傳遞給回呼目標
    callback(tom)
}

// 函式 doSomething 用來做點什麽
function doSomething(person) {
    const today = new Date().getDay()

    if (today == 0 || today == 6)
        console.log(`周末了，${person.name} 要去哪裏玩？`)
    else if (person.age > 100)
        console.log(`${person.name} 今天要去幽靈俱樂部`)
    else if (person.age > 20)
        console.log(`${person.name} 今天要工作`)
    else if (person.age > 6)
        console.log(`${person.name} 今天要上學`)
    else
        console.log(`${person.name} 只會玩玩玩！`)
}

// 函式 doNothing 什麽也不做
function doNothing(person) {
    console.log(`哦！抱歉，今天 ${person.name} 什麽都不做`)
}

// 向 main 傳遞 doSomething，doNothing 作為回呼目標
main(doSomething)
main(doNothing)