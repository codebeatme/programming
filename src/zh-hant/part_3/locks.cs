/*
本節文章
https://learnscript.net/zh-hant/programming/part-3/locks/ 什麽是鎖定
*/

// 類別 CreditCard，表示銀行卡
class CreditCard
{
    // 銀行卡余額，初始值為 1000
    private static int balance = 1000;
    // 用來判斷鎖定狀態的物件
    private static readonly object locker = new();

    // 銀行卡進行支付作業，支付金額為 amount
    public static void Pay(int amount)
    {
        // 確保同時只能有一個執行緒存取 balance 欄位
        lock (locker)
        {
            balance -= amount;
            // 暫止 5 秒
            Thread.Sleep(5000);
        }
    }

    // 取得當前的銀行卡余額
    public static int GetBalance()
    {
        // 確保同時只能有一個執行緒存取 balance 欄位
        lock (locker)
            return balance;
    }

}

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

// 一個用於被新執行緒呼叫的函式
void PayForMe()
{
    // 使用信用卡支付
    CreditCard.Pay(100);
}

Console.WriteLine("開啟一個執行緒，為我支付 100");
Thread thread = new(PayForMe);
thread.Start();

// 由於是在新執行緒中呼叫 PayForMe，主執行緒將很快執行到這裏
Console.WriteLine("現在我要檢視余額了哦！");
// 呼叫 GetBalance 將陷入等待，因為此時 Pay 方法持有鎖定
Console.WriteLine($"余額：{CreditCard.GetBalance()}");
*/