/*
本節文章
https://learnscript.net/zh-hant/programming/part-2/generators/ 什麽是產生器
*/

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

/// 傳回一個可以進行疊代的物件，包含整數 1 到 5
System.Collections.IEnumerator GetNumbers()
{
    for (int i = 1; i <= 5; i++)
        // 使用 yield return 實現 IEnumerator
        yield return i;
}

/// 將可疊代物件指派給 numbers
var numbers = GetNumbers();

// 周遊並顯示可疊代物件包含的元素
while (numbers.MoveNext())
    Console.WriteLine(numbers.Current);
*/