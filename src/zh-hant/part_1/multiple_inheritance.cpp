/*
本節文章
https://learnscript.net/zh-hant/programming/part-1/multiple-and-multilevel-inheritance/ 什麽是多重，多級繼承？有何不同
*/

#include <iostream>

/// 基礎類別 Plane
class Plane
{
public:
    // 方法 Flight，表示飛行功能
    void Flight()
    {
        std::cout << "看，是灰機！" << std::endl;
    }
};

/// 基礎類別 Boat
class Boat
{
public:
    // 方法 Row，表示劃水功能
    void Row()
    {
        std::cout << "看，是劃水專家！" << std::endl;
    }
};

/// 衍生類別 Airboat，同時繼承了 Plane，Boat
class Airboat : public Plane, public Boat
{
    // 擁有 Flight 和 Row 方法
};

/// 主函式
int main()
{
    /// 建立 Airboat 的執行個體
    Airboat airboat;

    /// 分別呼叫 Flight 和 Row 方法
    airboat.Flight();
    airboat.Row();

    ///
}