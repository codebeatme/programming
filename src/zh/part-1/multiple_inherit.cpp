/*
本节视频
https://www.bilibili.com/video/BV1Va4y1P7Hp/ 「编程指南」什么是多重继承？什么是多级继承？多重继承和多继承是否相同

多重继承是指一个类从多个基类继承的行为，多级继承是指某个派生类成为另一个类的基类的行为
* 多重继承和多继承，应该是同一个概念
* 导致区分两者的原因可能是对Multilevel Inheritance的错误翻译

版本
MinGW-w64 8.1.0
VSCode 1.77.3

相关视频
https://www.bilibili.com/video/BV1PV4y1f7SV/ 什么是类的继承？什么是基类和派生类？继承的作用，以及不能被继承的成员
https://www.bilibili.com/video/BV1Az4y1a715/ 什么是接口的多重继承

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
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