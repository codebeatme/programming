/*
本节文章
https://learnscript.net/zh/programming/part-2/interface-default-methods/ 什么是接口的默认方法
*/

/// 接口 IMovable，表示可交谈
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

/// 类 ChatRoom，实现了接口 ITalkable
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
ITalkable talkable = new ChatRoom();
talkable.Sender = "小刚";
talkable.Message = "这是一条没有用的消息";

// 将使用 ITalkable 接口的默认方法 Send
talkable.Send();
*/