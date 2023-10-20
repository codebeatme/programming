/*
本節文章
https://learnscript.net/zh-hant/programming/part-2/value-and-reference-types/ 什麽是實值型別，參考型別？有何不同
*/

/// 類別 Cup，表示了一個茶杯
class Cup {
    name = '大茶杯'
    price = 10
}

/// 參考型別變數，將保持對執行個體的參考
let cup1 = new Cup()
// cup2 和 cup1 會參考同一個執行個體
let cup2 = cup1

/// 無論通過 cup1，還是 cup2 修改或顯示欄位都是一樣的
cup1.name = '小茶杯'
cup1.price = 5
console.log(`${cup2.name} 價格為 ${cup2.price}`)