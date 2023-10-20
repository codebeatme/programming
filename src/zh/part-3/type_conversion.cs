/*
本节文章
https://learnscript.net/zh/programming/part-3/type-explicit-and-implicit-conversion/ 什么是类型的显式，隐式转换？有何不同
*/

// 类 Plant，表示植物
class Plant { }

// 类 Tree，表示树，继承自 Plant
class Tree : Plant { }

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 隐式转换
int small1 = 200;

// 长整型可以表示，所有整型可以表示的数字
long big1 = small1;

/// 显示转换
long big2 = 100000000000000;

// 整型不能完全表示，长整型可以表示的数字，信息可能丢失或改变
int small2 = (int)big2;

Console.WriteLine($"small2 和 big2 相等吗？{small2 == big2}");

///
// 创建一个 Tree 对象
Tree tree1 = new();

// 以下操作不会产生新的 Tree 对象
Plant plant = tree1;
Tree tree2 = (Tree)plant;
*/