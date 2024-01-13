/*
本節文章
https://learnscript.net/zh-hant/programming/part-2/interface-explicit-and-implicit-implementation/ 什麽是介面的明確，隱含實作？有何不同
*/

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

/// 建立 Car 的執行個體
Car car = new();

/// 通過 IMovable，IRotatable 介面呼叫 Show 方法
IMovable movable = car;
IRotatable rotatable = car;
movable.Show();
rotatable.Show();

/// ERROR 無法通過執行個體呼叫 Show 方法
// car.Show();
*/