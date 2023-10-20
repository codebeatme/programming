/*
本節文章
https://learnscript.net/zh-hant/programming/part-1/virtual-inheritance-and-base-classes-ambiguities/ 什麽是虛繼承，虛基礎類別，語意模糊
*/

#include <iostream>

/// 基礎類別 A，擁有 Show 方法
class A
{
public:
    void Show()
    {
        std::cout << "A::Show" << std::endl;
    }
};

/// 衍生類別 B1，B2 均擁有繼承自基礎類別 A 的 Show 方法
// class B1 : public A
// 改為采用虛繼承的方式
class B1 : virtual public A
{
};
// class B2 : public A
class B2 : virtual public A
{
};

/// 衍生類別 C，將擁有兩個 Show 方法
class C : public B1, public B2
{
};

/// 建立執行個體，並呼叫 Show 方法
int main()
{
    C c;
    // ERROR 無法確定呼叫哪一個 Show 方法
    c.Show();
}