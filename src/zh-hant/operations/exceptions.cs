/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

// 函式 Divide，實作除法，會檢查除數是否有問題
int Divide(int dividend, int divisor)
{

    // 除數不能為 0，否則擲回例外狀況
    if (divisor == 0)
        throw new Exception("參數 divisor 不能為 0！");

    return dividend / divisor;
}

// 攔截和處理例外狀況
try
{
    // 除數為 0，將擲回例外狀況
    Divide(7, 0);
}
catch (Exception err)
{
    // 簡單的顯示例外狀況的資訊
    Console.WriteLine($"糟糕，出現一個例外狀況！{err.Message}");
}
*/