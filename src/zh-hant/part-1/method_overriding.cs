/*
本節視頻
https://www.bilibili.com/video/BV1Xh41177AA/ 「程式設計指南」什麽是方法覆寫？方法覆寫有什麽用

本節文章
https://learnscript.net/zh-hant/programming/part-1/method-overriding/ 什麽是方法覆寫
*/

/*
//以下程式碼與 abstract.cs，virtual.cs 只能有一個不被註解

/// 基礎類別 Animal
class Animal
{
    // 方法 Bark，預設為動物無法發聲
    public virtual void Bark()
    {
        Console.WriteLine("抱歉，本動物無法發聲");
    }
}

/// 衍生類別 Kitty
class Kitty : Animal
{
    // 覆寫 Animal 的 Bark 方法，因為小貓可以發聲
    public override void Bark()
    {
        Console.WriteLine("小貓小貓，喵喵喵！");
    }
}

/// 衍生類別 Bunny，直接繼承 Animal 的 Bark 方法
class Bunny : Animal
{ }
*/

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

/// 建立 Kitty 和 Bunny 的執行個體
Kitty kitty = new Kitty();
Bunny bunny = new Bunny();

/// 分別呼叫 Bark 方法，將顯示不同資訊
kitty.Bark();
bunny.Bark();
*/