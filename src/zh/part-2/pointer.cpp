/*
本节视频
https://www.bilibili.com/video/BV1rL411Y76F/ 「编程指南」什么是指针和指针型变量？什么是取值和取地址？指针型变量和引用型变量的区别

指针表示的是某个值的内存地址，存储指针的变量被称为指针型变量
* 取值，指针表示了某个值的地址，取值就是获取该值
* 取地址，是指获取某个值的内存地址，会产生一个指针
* 引用型变量保持的引用，其实也是指针，但引用型变量会对其指针自动取值

版本
MinGW-w64 8.1.0
VSCode 1.77.3

相关视频
https://www.bilibili.com/video/BV1cM411G7VC/ 什么是值类型变量？什么是引用型变量？有什么区别
https://www.bilibili.com/video/BV1yM411N7Ti/ 什么是变量

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

#include <iostream>

// 主函数
int main()
{
    /// 定义了一个表示年龄的数组 ages
    int ages[] = {1, 2, 3, 4, 5};

    /// 定义指针型变量 pointer，并指向数组 ages
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