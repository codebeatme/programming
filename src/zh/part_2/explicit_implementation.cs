/*
本节文章
https://learnscript.net/zh/programming/part-2/interface-explicit-and-implicit-implementation/ 什么是接口的显式，隐式实现？有何不同
*/

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 创建 Car 的实例
Car car = new();

/// 通过 IMovable，IRotatable 接口调用 Show 方法
IMovable movable = car;
IRotatable rotatable = car;
movable.Show();
rotatable.Show();

/// ERROR 无法通过实例调用 Show 方法
// car.Show();
*/