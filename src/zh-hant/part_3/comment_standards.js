/*
本節文章
https://learnscript.net/zh-hant/programming/part-3/comment-standards/ 什麽是註解規格
*/

/// 一段清晰簡潔的描述？哦！

/// 這是一段非常關鍵的程式碼，( •̀ ω •́ )✧
let keyword = 10101010

/// 為類別的公用成員添加註解
class School {
    /**
     * 呼叫該方法，開始上課！
     */
    classBegin() { }
}

/// 以下程式碼被註解掉了
// message = '今天天氣如何？'
// console.log(message)

/// 可用於快速提示的註解
/**
 * 出售一樣物品
 * @param {string} item 需要出售的物品的名稱
 */
function sellSomething(item) { }
