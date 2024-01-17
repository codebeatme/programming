// 创建 MiddleSchool 类的实例
MiddleSchool school = new();
// 为事件 OnMessage 编写代码
school.OnMessage += (object? sender, EventArgs e) =>
    Console.WriteLine($"接到了学校的消息：{(e as MessageArgs)?.Message}");

// 调用 ClassBegin，事件 OnMessage 将被触发
school.ClassBegin();