/*
本节视频
https://www.bilibili.com/video/BV1bc411N7WQ/ 「编程指南」什么是接口的默认方法？默认方法的调用，默认实现的扩展

默认方法是接口约定的，并具有默认实现的方法
* 类可以不实现接口的默认方法
* 默认方法一般包含简单，不轻易改变的逻辑

版本
.NET 7.0.2
VSCode 1.77.3

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// 表示可交谈的接口
interface ITalkable
{
    // 消息的发送人
    string Sender { get; set; }
    // 消息的内容
    string Message { get; set; }

    // 发送消息到服务器
    void Send()
    {
        Console.WriteLine($"“{Sender}” 发送消息 “{Message}” 至服务器");
    }
}

/// 聊天室类，实现了接口 ITalkable
class ChatRoom : ITalkable
{
    // 实现接口的属性 Sender
    public string Sender { get; set; } = "<无名者>";
    // 实现接口的属性 Message
    public string Message { get; set; } = "<一条消息>";
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// 使用接口设置消息发送人和内容
ITalkable t = new ChatRoom();
t.Sender = "小刚";
t.Message = "这是一条没有用的消息";

// 将使用 ITalkable 接口的默认方法 Send
t.Send();
*/