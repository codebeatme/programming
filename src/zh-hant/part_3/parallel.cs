/*
本節文章
https://learnscript.net/zh-hant/programming/part-3/serial-parallel-concurrency/ 什麽是序列，平行，並行？有何不同
*/

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

// 執行第一個 for 迴圈的函式 fun1
void fun1()
{
    for (int i1 = 0; i1 < 10; i1++)
    {
        Console.WriteLine($"i1={i1}");
        // 暫止 0.5 秒
        Thread.Sleep(500);
    }
}
// 執行第二個 for 迴圈的函式 fun2
void fun2()
{
    for (int i2 = 0; i2 < 10; i2++)
    {
        Console.WriteLine($"i2={i2}");
        // 暫止 0.5 秒
        Thread.Sleep(500);
    }
}

// 通過兩個執行緒來平行執行兩個 for 迴圈
Thread thread1 = new(fun1);
Thread thread2 = new(fun2);

thread1.Start();
thread2.Start();
*/