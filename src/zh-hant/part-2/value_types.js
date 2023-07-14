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

/// 實值型別變數在讀取或寫入值時，互不影響
let message1 = '今天天氣不錯'
// 讀取 message1 的值，將該值寫入 message2
let message2 = message1

/// 為 message1 寫入新值，不會影響 message2
message1 = '今天天氣很糟糕'
// 顯示變數 message2，以觀察其值是否發生了變化
console.log(`message2 = ${message2}`)