/*
本節文章
https://learnscript.net/zh-hant/programming/part-3/boxing-and-unboxing/ 什麽是裝箱，拆箱
*/

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

// 方法的參數類型為 object，與 number 的類型不同
void printSomething(object something)
{
    if (something is int)
    {
        // 根據堆積中的 object 物件，產生一個等效的整數類型值，並儲存在堆疊中
        int n = (int)something;
        Console.WriteLine($"他是數值 {n}");
    }
}

// 變數 number 的值 1000 被儲存在堆疊中
int number = 1000;

// 將根據 1000 產生等效的 object 物件，並儲存在堆積中
printSomething(number);

*/