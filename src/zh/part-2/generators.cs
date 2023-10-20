/*
本节文章
https://learnscript.net/zh/programming/part-2/generators/ 什么是生成器
*/

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 返回一个可以进行迭代的对象，包含整数 1 到 5
System.Collections.IEnumerator GetNumbers()
{
    for (int i = 1; i <= 5; i++)
        // 使用 yield return 实现 IEnumerator
        yield return i;
}

/// 将可迭代对象赋值给 numbers
var numbers = GetNumbers();

// 遍历并显示可迭代对象包含的元素
while (numbers.MoveNext())
    Console.WriteLine(numbers.Current);
*/