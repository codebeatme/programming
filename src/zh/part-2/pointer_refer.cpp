/*
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

class Student
{
public:
    int age = 10;
};

// 主函数
int main()
{
    /// 创建 Student 类的实例 s1
    Student s1;

    /// 引用型变量 s2
    Student &s2 = s1;
    // 指针型变量 s3
    Student *s3 = &s1;

    /// 引用型变量修改实例的 age 字段，此时 s1.age 为 20
    s2.age = 20;
    std::cout << s1.age << std::endl;
    // 指针型变量先取值，然后修改实例的 age 字段，此时 s1.age 为 30
    (*s3).age = 30;
    std::cout << s1.age << std::endl;
    // 但 C++ 也可以使用如下方式修改 age 字段
    s3->age = 40;
    std::cout << s1.age << std::endl;
}