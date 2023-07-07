/*
本节视频
https://www.bilibili.com/video/BV1XM411g7kW/ 「编程指南」什么是事件？事件和委托的区别

事件可以被理解为一种特殊的委托，但存在以下不同
* 事件一般作为类的成员出现
* 事件一般通过自身的代码来触发

版本
.NET 7.0.2
VSCode 1.78.0

相关视频
https://www.bilibili.com/video/BV1jo4y1c7aX/ 什么是委托？委托的作用

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// 表示学校的类
class MySchool
{
    /// 表示学校发出了消息的事件
    public event EventHandler? OnMessage;

    /// 表示开始上课的方法
    public void ClassBegin()
    {
        // 触发事件，外部将可以收到来自学校的消息
        OnMessage?.Invoke(
            this,
            new MessageArgs()
            {
                Message = "上课了！"
            });
    }

    ///
}

/// 消息参数，包含了消息的内容
class MessageArgs : EventArgs
{
    // 消息的内容
    public string Message = string.Empty;
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 处理事件的函数，用来显示来自学校的消息
void ReceiveMessage(object? sender, EventArgs e)
{
    MessageArgs? param = e as MessageArgs;

    Console.WriteLine($"接到了学校的消息：{param?.Message}");
}

/// 创建 MySchool 类的实例
MySchool school = new MySchool();
// 将函数 ReceiveMessage 的引用添加至事件 OnMessage
school.OnMessage += ReceiveMessage;

// 调用 ClassBegin，事件 OnMessage 将被触发
school.ClassBegin();
*/