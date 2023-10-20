/*
本節文章
https://learnscript.net/zh-hant/programming/part-3/variadic-parameters/ 什麽是可變參數
*/

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

/// 顯示一組水果資訊的函式
void ListFruit(
    // list 是一個可變參數
    params Fruit[] list
    )
{
    Console.WriteLine($"一共有 {list.Length} 個水果");

    foreach (Fruit fruit in list)
        Console.WriteLine(fruit);
}

/// 可以為 ListFruit 指定多個 Fruit 和其衍生類別的執行個體
ListFruit(
    new Fruit(),
    new Orange(),
    new Orange(),
    new Fruit()
);
*/