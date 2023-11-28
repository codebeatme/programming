/*
本节文章
https://learnscript.net/zh/programming/part-3/serial-parallel-concurrency/ 什么是串行，并行，并发？有何不同
*/

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// 串行方式，代码依次执行
// 第一个 for 循环执行完毕后，才会执行第二个
for (int i1 = 0; i1 < 10; i1++)
    Console.WriteLine($"i1={i1}");

for (int i2 = 0; i2 < 10; i2++)
    Console.WriteLine($"i2={i2}");
*/