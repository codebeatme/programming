/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

/// A1 是編譯時常數
const int A1 = 13;

/// A2 是編譯時常數，因為運算式可以在編譯時計算出結果
const int A2 = 13 + A1;

int b1 = 0;
/// ERROR A3 是一個錯誤的編譯時常數，因為 b1 的值在編譯時是無法確定的
const int A3 = b1;
*/