using System.Numerics;

// 介面 IMovable，表示可移動
interface IMovable
{
    // 屬性 Location，表示當前位置
    public Vector2 Location { get; set; }

    // 屬性 Speed，表示移動速度
    public Vector2 Speed { get; set; }

    // 方法 Move，表示移動一次
    public void Move()
    {
        // 預設實作為，按照速度調整當前位置
        Location += Speed;
    }
}

// 介面 IEMailable，表示可投遞電子郵件
interface IEMailable
{
    // 屬性 Location，表示電子郵件的位址
    public string Location { get; set; }
}

// 類別 Car
// class Car : IMovable
class Car : IMovable, IEMailable
{
    // 明確實作了 IMovable 介面的成員 Location
    Vector2 IMovable.Location { get; set; }
    // 明確實作了 IEMailable 介面的成員 Location
    // 好吧，這是預約該車的方式
    string IEMailable.Location { get; set; } = string.Empty;

    // 隱含實作了 IMovable 介面的成員 Speed
    public Vector2 Speed { get; set; }
}

// 介面 IMovable，表示可旋轉
interface IRotatable
{
    // 屬性 Angle，表示當前角度
    public float Angle { get; set; }
    // 屬性 Speed，表示旋轉速度
    public float Speed { get; set; }

    // 方法 Rotate，表示旋轉一次
    public void Rotate()
    {
        // 預設實作為，按照速度旋轉當前角度
        Angle += Speed;
    }
}

// 介面 IMovable，表示可駕駛
interface IDrivable : IMovable, IRotatable { }

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

using System.Numerics;

// 函式 Go，用來移動一個可移動的目標
void Go(IMovable movable)
{

    // 如果速度為 0，則不需要移動
    if (movable.Speed == Vector2.Zero) {
        Console.WriteLine("當前速度為 0？拋錨了？");
        return;
    }

    // 移動並顯示位置
    movable.Move();
    Console.WriteLine($"移動後的位置：{movable.Speed}");
}

// 建立 Car 的執行個體
Car car = new()
{
    // 設定移動速度
    Speed = new Vector2(1.5f, 2.5f)
};

// 呼叫 Go 方法進行移動
Go(car);
*/