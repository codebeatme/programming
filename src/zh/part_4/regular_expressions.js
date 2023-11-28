/*
本节文章
https://learnscript.net/zh/programming/part-4/regular-expressions/ 什么是正则表达式
*/

// 函数 check_email 用来检查邮箱地址的有效性
function check_email(email) {
    // 这是邮箱地址的正则表达式
    const re = /\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*/

    return re.test(email)
}

console.log(`邮箱地址 test@abc.com 有效？${check_email('test@abc.com')}`)
console.log(`邮箱地址 abc@abc 有效？${check_email('abc@abc')}`)


let text = '我们班级的人数很多，很多。我们班级的桌子很多，很多。我喜欢我们的班级。'

// 使用正则表达式，替换句子开头的词汇
text = text.replace(/(?<=(^|。))我们/g, '你们')
console.log(text)