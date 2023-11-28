/*
本节文章
https://learnscript.net/zh/programming/part-3/synchronous-and-asynchronous/ 什么是同步，异步？有何不同
*/

/*
请将以下代码复制到 某个窗口的代码文件 中，以运行本节示例

// 获取一个指定页面的 HTML 代码
string getHTML()
{

    try
    {
        HttpClient http = new();
        // 这个页面是不存在的，这样方法 getHTML 将执行较长的时间
        return http.GetStringAsync("http://www.bing.abcdefg/").Result;
    }
    catch
    {
        return "啊！出错了！";
    }

}

// 需要绑定某个按钮的点击事件
void btnGetHTMLClick(object sender, EventArgs e)
{
    // 同步执行方法 getHTML
    string html = getHTML();
    MessageBox.Show(html);
}
*/