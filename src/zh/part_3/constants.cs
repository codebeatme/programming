/*
本节文章
https://learnscript.net/zh/programming/part-3/compile-and-run-time-constants/ 什么是编译时，运行时常量？有何不同
*/

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 通过字面量为常量赋值
const int A1 = 13;

/// A1 是常量，所以表达式可以在编译时计算出结果
const int A2 = 13 + A1;

int b1 = 0;
/// ERROR 常量 A3 的值不能在编译时被确定，因为 b1 的值在编译时是无法确定的
const int A3 = b1;

/// A1 处被替换为 13，A2 处被替换为 26
Console.WriteLine($"{A1} {A2}");
*/