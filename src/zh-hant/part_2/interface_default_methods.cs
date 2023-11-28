/*
本節文章
https://learnscript.net/zh-hant/programming/part-2/interface-default-methods/ 什麽是介面的預設方法
*/

/// 介面 IMovable，表示可交談
interface ITalkable
{
    // 訊息的發送人
    string Sender { get; set; }
    // 訊息的內容
    string Message { get; set; }

    // 發送訊息到伺服器
    void Send()
    {
        Console.WriteLine($"“{Sender}” 發送訊息 “{Message}” 至伺服器");
    }
}

/// 類別 ChatRoom，實現了介面 ITalkable
class ChatRoom : ITalkable
{
    // 實現介面的屬性 Sender
    public string Sender { get; set; } = "<無名者>";
    // 實現介面的屬性 Message
    public string Message { get; set; } = "<一條訊息>";
}

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

// 使用介面設定訊息發送人和內容
ITalkable talkable = new ChatRoom();
talkable.Sender = "小剛";
talkable.Message = "這是一條沒有用的訊息";

// 將使用 ITalkable 介面的預設方法 Send
talkable.Send();
*/