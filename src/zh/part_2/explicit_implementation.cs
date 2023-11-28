/*
本节文章
https://learnscript.net/zh/programming/part-2/interface-explicit-and-implicit-implementation/ 什么是接口的显式，隐式实现？有何不同
*/

/// 接口 IMovable，表示可移动性
interface IMovable
{
    // 显示剩余可供移动的能量
    void Show();
}

/// 接口 IRotatable，表示可旋转性
interface IRotatable
{
    // 显示当前的旋转角度
    void Show();
}

/// 类 Car，实现了接口 IMovable，IRotatable
class Car : IMovable, IRotatable
{
    // 隐式实现，同时显示剩余的油量和方向盘的角度
    // public void Show()
    // {
    //     Console.WriteLine("糟糕只剩 3 克油了，而且方向盘转到了 -90 度");
    // }

    /// 显式实现，分别显示剩余的油量和方向盘的角度
    void IMovable.Show()
    {
        Console.WriteLine("只剩 3 克油了");
    }
    void IRotatable.Show()
    {
        Console.WriteLine("方向盘 -90 度了");
    }
    ///
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 创建 Car 的实例
Car car = new();

/// 通过 IMovable，IRotatable 接口调用 Show 方法
IMovable movable = car;
IRotatable rotatable = car;
movable.Show();
rotatable.Show();

/// ERROR 无法通过实例调用 Show 方法
// car.Show();
*/