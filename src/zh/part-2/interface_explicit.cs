/*
本节视频
https://www.bilibili.com/video/BV1FV4y1d7pq/ 「编程指南」什么是接口的显式实现和隐式实现？显式实现和隐式实现的区别，显式实现的作用

显式实现可以让类，同时实现多个接口中声明的相同的成员
* 显式实现的成员，一般只能通过接口来访问
* 隐式实现的成员，则不受这些限制

版本
.NET 7.0.2
VSCode 1.77.3

相关视频
https://www.bilibili.com/video/BV1bo4y1879U/ 什么是类？什么是对象和实例？类和对象实例的区别

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// 表示可移动性的接口
interface IMovable
{
    // 显示剩余可供移动的能量
    void Show();
}

/// 表示可旋转性的接口
interface IRotatable
{
    // 显示当前的旋转角度
    void Show();
}

/// 汽车类，实现了接口 IMovable，IRotatable
class Car : IMovable, IRotatable
{
    // 隐式实现，同时显示剩余的油量和方向盘的角度
    // public void Show()
    // {
    //     Console.WriteLine($"糟糕只剩3克油了，而且方向盘转到了-90度");
    // }

    ///
    void IMovable.Show() {
        Console.WriteLine($"只剩3克油了");
    }
    void IRotatable.Show() {
        Console.WriteLine($"方向盘-90度了");
    }
    ///
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 创建 Car 的实例
Car car = new Car();

/// 通过 IMovable，IRotatable 接口调用 Show 方法
IMovable m = car;
IRotatable r = car;
m.Show();
r.Show();

/// 无法通过实例调用 Show
// car.Show();
*/