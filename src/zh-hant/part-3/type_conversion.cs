/*
本節文章
https://learnscript.net/zh-hant/programming/part-3/type-explicit-and-implicit-conversion/ 什麽是型別的明確，隱含轉換？有何不同
*/

// 類別 Plant，表示植物
class Plant { }

// 類別 Tree，表示樹，繼承自 Plant
class Tree : Plant { }

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

/// 隱含轉換
int small1 = 200;

// 長整型可以表示，所有整型可以表示的數值
long big1 = small1;

/// 顯示轉換
long big2 = 100000000000000;

// 整型不能完全表示，長整型可以表示的數值，資訊可能丟失或改變
int small2 = (int)big2;

Console.WriteLine($"small2 和 big2 相等嗎？{small2 == big2}");

///
// 建立一個 Tree 物件
Tree tree1 = new();

// 以下作業不會產生新的 Tree 物件
Plant plant = tree1;
Tree tree2 = (Tree)plant;
*/