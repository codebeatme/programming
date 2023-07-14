/*
本節視頻
https://www.bilibili.com/video/BV1cM411G7VC/ 「程式設計指南」什麽是實值型別變數？什麽是引用型變數？有什麽區別

直接儲存值的變數被稱為實值型別變數，保持對值的引用的變數被稱為引用型變數
* 實值型別變數所儲存的值，與其他變數沒有關系
* 引用型變數可能會對同一個值進行存取和操作

版本
Node.js 18.15.0
VSCode 1.77.3

相關視頻
https://www.bilibili.com/video/BV1yM411N7Ti/ 什麽是變數
https://www.bilibili.com/video/BV1bo4y1879U/ 什麽是類別？什麽是物件和執行個體？類別和物件執行個體的區別
https://www.bilibili.com/video/BV1vk4y1j7Eo/ 什麽是堆和棧？堆和棧在儲存值時的區別

關於本系列教程的使用說明和相關問題解答，請參考文章 https://www.bilibili.com/read/cv23041317
*/

/// 類別 Cup
class Cup {
    name = '大茶杯'
    price = 10
}

/// 引用型變數，將保持對執行個體的引用
let cup1 = new Cup()
// cup2 和 cup1 會引用同一個執行個體
let cup2 = cup1

/// 無論通過 cup1，還是 cup2 修改或顯示欄位都是一樣的
cup1.name = '小茶杯'
cup1.price = 5
console.log(`${cup2.name} 價格為 ${cup2.price}`)