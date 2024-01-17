// delegate 是一个语法糖，他会转化为一个类的定义
delegate void Loaded(string data);

// 类 MiddleSchool，表示中学
class MiddleSchool
{
    // 事件 OnMessage，表示学校发出了消息
    public event EventHandler? OnMessage;

    // 方法 ClassBegin，开始上课
    public void ClassBegin()
    {
        // 触发事件，外部将收到来自学校的消息
        OnMessage?.Invoke(this, new MessageArgs() { Message = "上课了！" });
    }
}

// 类 MessageArgs，事件参数，包含了消息的内容
class MessageArgs : EventArgs
{
    // 消息的内容
    public string Message = string.Empty;
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// 委托 Loaded 的实例 showMessage
Loaded showMessage = data =>
    Console.WriteLine("数据下载完毕！");

// 委托 Loaded 的实例 showData
Loaded showData = data =>
    Console.WriteLine($"数据内容为：{data}");

// 合并 showMessage，showData
Loaded loaded = showMessage + showData;
// 将 loaded 传递给函数 Load
Load(loaded);

// 函数 Load，用于从服务器下载数据
void Load(Loaded loaded) {
    // 这里假设 data 是从服务器获取的数据
    string data = "好吧，假设这是从服务器获取的数据！";

    // 调用 loaded 所包含的匿名函数
    loaded.Invoke(data);
}

// 创建 MiddleSchool 类的实例
MiddleSchool school = new();
// 为事件 OnMessage 编写代码
school.OnMessage += (object? sender, EventArgs e) =>
    Console.WriteLine($"接到了学校的消息：{(e as MessageArgs)?.Message}");

// 调用 ClassBegin，事件 OnMessage 将被触发
school.ClassBegin();
*/