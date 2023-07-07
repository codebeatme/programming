/*
本节视频
https://www.bilibili.com/video/BV1ta4y1P73Z/ 「编程指南」什么是访问级别？私有，保护和公共访问级别的区别，以及访问级别的扩展

访问级别用于控制目标的可访问性，主要针对类的成员，但也可用于类，结构或接口本身
* 私有成员，只能被定义他的类访问
* 保护成员，可以被定义他的类及其派生类访问
* 公共成员，可以在任意位置访问

版本
.NET 7.0.2
VSCode 1.77.3

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// 基类 Device
class Device
{
    // 字段 id
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
    //     return id;
    // }
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

Device device = new Device();
device.id = Guid.NewGuid();
*/