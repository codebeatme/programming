/*
本节文章
https://learnscript.net/zh/programming/part-1/multiple-and-multilevel-inheritance/ 什么是多重，多级继承？有何不同
*/

#include <iostream>

/// 基类 Plane
class Plane
{
public:
    // 方法 Flight，表示飞行功能
    void Flight()
    {
        std::cout << "看，是灰机！" << std::endl;
    }
};

/// 基类 Boat
class Boat
{
public:
    // 方法 Row，表示划水功能
    void Row()
    {
        std::cout << "看，是划水专家！" << std::endl;
    }
};

/// 派生类 Airboat，同时继承了 Plane，Boat
class Airboat : public Plane, public Boat
{
    // 拥有 Flight 和 Row 方法
};

/// 主函数
int main()
{
    /// 创建 Airboat 的实例
    Airboat airboat;

    /// 分别调用 Flight 和 Row 方法
    airboat.Flight();
    airboat.Row();

    ///
}