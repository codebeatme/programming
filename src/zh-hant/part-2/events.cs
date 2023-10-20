/*
本節文章
https://learnscript.net/zh-hant/programming/part-2/events/ 什麽是事件？事件和委派有何不同
*/

/// 類別 MiddleSchool，表示中學
class MiddleSchool
{
    /// 表示學校發出了訊息的事件
    public event EventHandler? OnMessage;

    /// 表示開始上課的方法
    public void ClassBegin()
    {
        // 觸發事件，外部將可以收到來自學校的訊息
        OnMessage?.Invoke(
            this,
            new MessageArgs()
            {
                Message = "上課了！"
            });
    }

    ///
}

/// 訊息參數，包含了訊息的內容
class MessageArgs : EventArgs
{
    // 訊息的內容
    public string Message = string.Empty;
}

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

/// 處理事件的函式，用來顯示來自學校的訊息
void ReceiveMessage(object? sender, EventArgs e)
{
    MessageArgs? param = e as MessageArgs;

    Console.WriteLine($"接到了學校的訊息：{param?.Message}");
}

/// 建立 MiddleSchool 類別的執行個體
MiddleSchool school = new();
// 將函式 ReceiveMessage 的參考添加至事件 OnMessage
school.OnMessage += ReceiveMessage;

// 呼叫 ClassBegin，事件 OnMessage 將被觸發
school.ClassBegin();
*/