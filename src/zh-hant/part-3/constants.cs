/*
本節文章
https://learnscript.net/zh-hant/programming/part-3/compile-and-run-time-constants/ 什麽是編譯時，執行時常數？有何不同
*/

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

/// 通過常值為常數指派
const int A1 = 13;

/// A1 是常數，所以運算式可以在編譯時計算出結果
const int A2 = 13 + A1;

int b1 = 0;
/// ERROR 常數 A3 的值不能在編譯時被確定，因為 b1 的值在編譯時是無法確定的
const int A3 = b1;

/// A1 處被取代為 13，A2 處被取代為 26
Console.WriteLine($"{A1} {A2}");
*/