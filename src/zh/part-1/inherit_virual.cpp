/*
本节视频
https://www.bilibili.com/video/BV1ah4y1H7DS/ 「编程指南」什么是虚继承和虚基类？什么是多义性？虚继承的作用

多义性可以指由来自多个基类的同名成员导致的歧义问题，可通过虚继承得到部分解决
* 虚基类是指被派生类虚继承的基类
* 当一些类拥有同一个虚基类时，这些类派生的某个类，将只拥有一份来自虚基类的成员

版本
MinGW-w64 8.1.0
VSCode 1.77.3

相关视频
https://www.bilibili.com/video/BV1Va4y1P7Hp/ 什么是多重继承？什么是多级继承？多重继承和多继承是否相同
https://www.bilibili.com/video/BV1PV4y1f7SV/ 什么是类的继承？什么是基类和派生类？继承的作用，以及不能被继承的成员

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

#include <iostream>

/// 基类 A，拥有 Show 方法
class A
{
public:
    void Show()
    {
        std::cout << "A::Show" << std::endl;
    }
};

/// 派生类 B1，B2 均拥有继承自基类 A 的 Show 方法
class B1 : virtual public A
{
};
class B2 : virtual public A
{
};

/// 派生类 C，将拥有两个 Show 方法，一个继承自 B1，一个继承自 B2，如果 B1 和 B2 同时采用虚继承，则 C 将只拥有一个 Show 方法
class C : public B1, public B2
{
};

/// 创建实例，并调用 Show 方法
int main()
{
    C c;
    c.Show();
}