/*
本節文章
https://learnscript.net/zh-hant/programming/part-3/synchronous-and-asynchronous/ 什麽是同步，非同步？有何不同
*/

/*
請將以下程式碼複製到 某個視窗的程式碼檔案 中，以執行本節範例

// 取得一個指定頁面的 HTML 程式碼
async Task<string> getHTML()
{

    try
    {
        HttpClient http = new();
        // 這個頁面是不存在的，這樣方法 getHTML 將執行較長的時間
        return await http.GetStringAsync("http://www.bing.abcdefg/");
    }
    catch
    {
        return "啊！出錯了！";
    }
}

// 需要繫結某個按鈕的點選事件
async void btnGetHTMLClick(object sender, EventArgs e)
{
    // 非同步執行方法 getHTML
    string html = await getHTML();
    MessageBox.Show(html);
}
*/