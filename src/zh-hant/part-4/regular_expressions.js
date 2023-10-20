/*
本節文章
https://learnscript.net/zh-hant/programming/part-4/regular-expressions/ 什麽是規則運算式
*/

// 函式 check_email 用來檢查電子郵件地址的有效性
function check_email(email) {
    // 這是電子郵件地址的規則運算式
    const re = /\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*/

    return re.test(email)
}

console.log(`電子郵件地址 test@abc.com 有效？${check_email('test@abc.com')}`)
console.log(`電子郵件地址 abc@abc 有效？${check_email('abc@abc')}`)


let text = '我們班級的人數很多，很多。我們班級的桌子很多，很多。我喜歡我們的班級。'

// 使用規則運算式，取代句子開頭的詞匯
text = text.replace(/(?<=(^|。))我們/g, '你們')
console.log(text)