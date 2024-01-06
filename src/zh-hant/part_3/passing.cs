/*
本節文章
https://learnscript.net/zh-hant/programming/part-3/passing-by-value-and-reference/ 什麽是傳值，傳址？有何不同
*/

// 類別 Fruit，表示水果
class Fruit
{
    public override string ToString()
    {
        return "我是水果！";
    }
}

// 類別 Orange，表示橙子
class Orange : Fruit
{
    public override string ToString()
    {
        return "這是一個橙子！";
    }
}

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

/// 傳址
unsafe
{
    int num1 = 100;
    ref int num2 = ref num1;

    // num1，num2 在堆疊中儲存資料的位址一樣
    Console.WriteLine($"num1 用來儲存值的位址為：{(int)&num1:x}");
    fixed (int* pnum2 = &num2)
        Console.WriteLine($"num2 用來儲存值的位址為：{(int)pnum2:x}");

    // 對 num2 指派，等同於對 num1 指派
    num2 = 200;
    Console.WriteLine($"num1={num1}");
}

/// 傳值
// num1，num2 在堆疊中儲存資料的位址不同
Fruit fruit1 = new();
Fruit fruit2 = fruit1;

// 對 fruit2 指派，fruit1 不受影響
fruit2 = new Orange();

Console.WriteLine($"fruit1={fruit1}");
Console.WriteLine($"fruit2={fruit2}");
*/