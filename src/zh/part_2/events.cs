/*
本节文章
https://learnscript.net/zh/programming/part-2/events/ 什么是事件？事件和委托有何不同
*/

/// 类 MiddleSchool，表示中学
class MiddleSchool
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

/// 创建 MiddleSchool 类的实例
MiddleSchool school = new();
// 将函数 ReceiveMessage 的引用添加至事件 OnMessage
school.OnMessage += ReceiveMessage;

// 调用 ClassBegin，事件 OnMessage 将被触发
school.ClassBegin();
*/