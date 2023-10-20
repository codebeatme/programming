/*
本节文章
https://learnscript.net/zh/programming/part-3/boxing-and-unboxing/ 什么是装箱，拆箱
*/

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// 方法的参数类型为 object，与 number 的类型不同
void printSomething(object something)
{
    if (something is int)
    {
        // 根据堆中的 object 对象，产生一个等效的整型值，并存储在栈中
        int n = (int)something;
        Console.WriteLine($"他是数字 {n}");
    }
}

// 变量 number 的值 1000 被存储在栈中
int number = 1000;

// 将根据 1000 产生等效的 object 对象，并存储在堆中
printSomething(number);

*/