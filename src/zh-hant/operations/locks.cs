/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

// 余額，初始值為 1000
int balance = 1000;
// 用來請求鎖定的權杖
object locker = new();

// 函式 Pay，進行支付作業
void Pay(int amount)
{
    // 請求獨占鎖定，確保只有一個目標正在存取 balance
    lock (locker)
    {
        balance -= amount;
        // 修改余額後等待 5 秒
        Thread.Sleep(5000);
    }
}

// 取得當前的余額
int GetBalance()
{
    // 請求獨占鎖定，確保只有一個目標正在存取 balance
    lock (locker)
        return balance;
}

Console.WriteLine("開啟一個執行緒，支付 100");
Thread thread = new(() => Pay(100));
thread.Start();

Console.WriteLine("現在我要檢視余額！");
// 呼叫 GetBalance 將陷入等待，因為此時 Pay 方法持有鎖定
Console.WriteLine($"余額：{GetBalance()}");

// 用來請求鎖定的權杖
object lockerA = new();
object lockerB = new();

// 執行緒 I 先後使用權杖 lockerA，lockerB 取得獨占鎖定
new Thread(() =>
{
    lock (lockerA)
    {
        Console.WriteLine("執行緒 I 已經取得鎖定 A");
        Thread.Sleep(2000);

        Console.WriteLine("執行緒 I 嘗試取得鎖定 B");
        lock (lockerB)
            Console.WriteLine("執行緒 I 已經取得鎖定 B");
    }
}).Start();

// 執行緒 II 先後使用權杖 lockerB，lockerA 取得獨占鎖定
new Thread(() =>
{
    lock (lockerB)
    {
        Console.WriteLine("執行緒 II 已經取得鎖定 B");
        Thread.Sleep(2000);

        Console.WriteLine("執行緒 II 嘗試取得鎖定 A");
        lock (lockerA)
            Console.WriteLine("執行緒 II 已經取得鎖定 A");
    }
}).Start();

*/