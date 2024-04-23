#include <iostream>

/// 基底類別 A，擁有 Show 方法
class A
{
public:
    void Show()
    {
        std::cout << "A::Show" << std::endl;
    }
};

/// 衍生類別 B1，B2 均繼承自 A
// class B1 : public A
// 改為采用虛擬繼承的方式
class B1 : virtual public A
{
};
// class B2 : public A
class B2 : virtual public A
{
};

/// 衍生類別 C，將繼承 A 兩次
class C : public B1, public B2
{
};

/// 建立執行個體，並呼叫 Show 方法
int main()
{
    C c;
    // ERROR 無法確定呼叫哪個 A 的 Show 方法
    c.Show();
}