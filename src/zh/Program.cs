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
