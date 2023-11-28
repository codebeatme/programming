/*
本节文章
https://learnscript.net/zh/programming/part-2/pointers/ 什么是指针？指针和引用类型有何不同
*/

#include <iostream>

// 主函数
int main()
{
    /// 定义了一个表示年龄的数组 ages
    int ages[] = {1, 2, 3, 4, 5};

    /// 定义指针变量 pointer，并指向数组 ages
    int *pointer;
    pointer = ages;

    /// 显示数组中每一个元素的内存地址和值
    for (int i = 0; i < 5; i++)
    {
        // 使用 pointer 来显示元素的内存地址
        std::cout << "ages[" << i << "] 的地址为 " << pointer << std::endl;
        // 使用 *pointer 来取值，也就是获取元素的值
        std::cout << "ages[" << i << "] 的值为 " << *pointer << std::endl;

        // 将指针移动到下一个元素的内存地址
        pointer++;
    }

    ///
}