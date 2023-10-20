/*
本节文章
https://learnscript.net/zh/programming/part-1/access-levels-private-protected-public/ 什么是访问级别？私有，保护，公共访问级别有何不同
*/

/// 基类 Device
class Device
{
    // 字段 id
    // public Guid id = Guid.NewGuid();
    // protected Guid id = Guid.NewGuid();
    private Guid id = Guid.NewGuid();

    // 方法 Show 可以访问字段 id
    public virtual void Show()
    {
        Console.WriteLine($"设备ID {id}");
    }
}

/// 派生类 Phone
class Phone : Device
{
    // Guid GetID()
    // {
    //     // ERROR 字段 id 无法被访问
    //     return id;
    // }
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

Device device = new();
// ERROR 字段 id 无法被访问
device.id = Guid.NewGuid();
*/