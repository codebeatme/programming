/*
本節文章
https://learnscript.net/zh-hant/programming/part-2/interface-explicit-and-implicit-implementation/ 什麽是介面的明確，隱含實現？有何不同
*/

/// 介面 IMovable，表示可移動性
interface IMovable
{
    // 顯示剩余可供移動的能量
    void Show();
}

/// 介面 IRotatable，表示可旋轉性
interface IRotatable
{
    // 顯示當前的旋轉角度
    void Show();
}

/// 類別 Car，實現了介面 IMovable，IRotatable
class Car : IMovable, IRotatable
{
    // 隱含實現，同時顯示剩余的油量和方向盤的角度
    // public void Show()
    // {
    //     Console.WriteLine("糟糕只剩 3 克油了，而且方向盤轉到了 -90 度");
    // }

    /// 明確實現，分別顯示剩余的油量和方向盤的角度
    void IMovable.Show()
    {
        Console.WriteLine("只剩 3 克油了");
    }
    void IRotatable.Show()
    {
        Console.WriteLine("方向盤 -90 度了");
    }
    ///
}

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

/// 建立 Car 的執行個體
Car car = new();

/// 通過 IMovable，IRotatable 介面呼叫 Show 方法
IMovable movable = car;
IRotatable rotatable = car;
movable.Show();
rotatable.Show();

/// ERROR 無法通過執行個體呼叫 Show 方法
// car.Show();
*/