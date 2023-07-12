/*
本节视频
https://www.bilibili.com/video/BV1ah4y1H7DS/ 「编程指南」什么是虚继承和虚基类？什么是多义性？虚继承的作用

本节文章
https://learnscript.net/zh/programming/part-1/virtual-inheritance-and-base-classes-ambiguities/ 什么是虚继承，虚基类，多义性
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
// class B1 : public A
// 改为采用虚继承的方式
class B1 : virtual public A
{
};
// class B2 : public A
class B2 : virtual public A
{
};

/// 派生类 C，将拥有两个 Show 方法
class C : public B1, public B2
{
};

/// 创建实例，并调用 Show 方法
int main()
{
    C c;
    // ERROR 无法确定调用哪一个 Show 方法
    c.Show();
}