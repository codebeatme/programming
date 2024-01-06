/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// A1 是编译时常量
const int A1 = 13;

/// A2 是编译时常量，因为表达式可以在编译时计算出结果
const int A2 = 13 + A1;

int b1 = 0;
/// ERROR A3 是一个错误的编译时常量，因为 b1 的值在编译时是无法确定的
const int A3 = b1;
*/