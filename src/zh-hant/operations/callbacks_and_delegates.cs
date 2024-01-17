// delegate 是一個語法糖，他會轉化為一個類別的定義
delegate void Loaded(string data);

// 類別 MiddleSchool，表示中學
class MiddleSchool
{
    // 事件 OnMessage，表示學校發出了訊息
    public event EventHandler? OnMessage;

    // 方法 ClassBegin，開始上課
    public void ClassBegin()
    {
        // 觸發事件，外部將收到來自學校的訊息
        OnMessage?.Invoke(this, new MessageArgs() { Message = "上課了！" });
    }
}

// 類別 MessageArgs，事件參數，包含了訊息的內容
class MessageArgs : EventArgs
{
    // 訊息的內容
    public string Message = string.Empty;
}

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

// 委派 Loaded 的執行個體 showMessage
Loaded showMessage = data =>
    Console.WriteLine("資料下載完畢！");

// 委派 Loaded 的執行個體 showData
Loaded showData = data =>
    Console.WriteLine($"資料內容為：{data}");

// 合併 showMessage，showData
Loaded loaded = showMessage + showData;
// 將 loaded 傳遞給函式 Load
Load(loaded);

// 函式 Load，用於從伺服器下載資料
void Load(Loaded loaded) {
    // 這裏假設 data 是從伺服器取得的資料
    string data = "好吧，假設這是從伺服器取得的資料！";

    // 呼叫 loaded 所包含的匿名函式
    loaded.Invoke(data);
}

// 建立 MiddleSchool 類別的執行個體
MiddleSchool school = new();
// 為事件 OnMessage 編寫程式碼
school.OnMessage += (object? sender, EventArgs e) =>
    Console.WriteLine($"接到了學校的訊息：{(e as MessageArgs)?.Message}");

// 呼叫 ClassBegin，事件 OnMessage 將被觸發
school.ClassBegin();
*/