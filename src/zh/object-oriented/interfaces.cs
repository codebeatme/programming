using System.Numerics;

// 接口 IMovable，表示可移动
interface IMovable
{
    // 属性 Location，表示当前位置
    public Vector2 Location { get; set; }

    // 属性 Speed，表示移动速度
    public Vector2 Speed { get; set; }

    // 方法 Move，表示移动一次
    public void Move()
    {
        // 默认实现为，按照速度调整当前位置
        Location += Speed;
    }
}

// 接口 IEMailable，表示可投递电子邮件
interface IEMailable
{
    // 属性 Location，表示电子邮件的地址
    public string Location { get; set; }
}

// 类 Car
// class Car : IMovable
class Car : IMovable, IEMailable
{
    // 显式实现了 IMovable 接口的成员 Location
    Vector2 IMovable.Location { get; set; }
    // 显式实现了 IEMailable 接口的成员 Location
    // 好吧，这是预约该车的方式
    string IEMailable.Location { get; set; } = string.Empty;

    // 隐式实现了 IMovable 接口的成员 Speed
    public Vector2 Speed { get; set; }
}

// 接口 IMovable，表示可旋转
interface IRotatable
{
    // 属性 Angle，表示当前角度
    public float Angle { get; set; }
    // 属性 Speed，表示旋转速度
    public float Speed { get; set; }

    // 方法 Rotate，表示旋转一次
    public void Rotate()
    {
        // 默认实现为，按照速度旋转当前角度
        Angle += Speed;
    }
}

// 接口 IMovable，表示可驾驶
interface IDrivable : IMovable, IRotatable { }

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

using System.Numerics;

// 函数 Go，用来移动一个可移动的目标
void Go(IMovable movable) {

    // 如果速度为 0，则不需要移动
    if (movable.Speed == Vector2.Zero) {
        Console.WriteLine("当前速度为 0？抛锚了？");
        return;
    }

    // 移动并显示位置
    movable.Move();
    Console.WriteLine($"移动后的位置：{movable.Speed}");
}

// 创建 Car 的实例
Car car = new()
{
    // 设置移动速度
    Speed = new Vector2(1.5f, 2.5f)
};

// 调用 Go 方法进行移动
Go(car);
*/