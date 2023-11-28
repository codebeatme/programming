/*
本節文章
https://learnscript.net/zh-hant/programming/part-3/optional-parameters/ 什麽是選擇性參數
*/

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

/// 顯示歡迎訊息的函式
void Welcome(
    string name,
    // message 是一個選擇性參數，擁有預設值 "你好！{0}"
    string message = "你好！{0}"
    )
{
    Console.WriteLine(message, name);
}

/// 可以不為選擇性參數 message 指定值
Welcome("大花貓");
*/