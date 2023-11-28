/*
本節文章
https://learnscript.net/zh-hant/programming/part-3/serial-parallel-concurrency/ 什麽是序列，平行，並行？有何不同
*/

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

// 序列方式，程式碼依次執行
// 第一個 for 迴圈執行完畢後，才會執行第二個
for (int i1 = 0; i1 < 10; i1++)
    Console.WriteLine($"i1={i1}");

for (int i2 = 0; i2 < 10; i2++)
    Console.WriteLine($"i2={i2}");
*/