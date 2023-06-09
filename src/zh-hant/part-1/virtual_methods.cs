/*
本節視頻
https://www.bilibili.com/video/BV1CM411L7j8/ 「程式設計指南」什麽是虛擬方法？虛擬方法和抽象方法的異同，虛擬成員的拓展

本節文章
https://learnscript.net/zh-hant/programming/part-1/virtual-methods/ 什麽是虛擬方法？虛擬和抽象方法有何不同
*/

/// 基礎類別 Animal
class Animal
{
    // 方法 Bark，預設為動物無法發聲
    public virtual void Bark()
    {
        Console.WriteLine("抱歉，本動物無法發聲");
    }

    // public virtual int Age {
    //     get;
    // }
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

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

/// 虛擬方法本身已經被實現，因此可以建立相關執行個體
Animal animal = new Animal();
Kitty kitty = new Kitty();
Bunny bunny = new Bunny();

/// 呼叫 Bark 方法
animal.Bark();
// Kitty 覆寫了虛擬方法 Bark
kitty.Bark();
// Bunny 直接繼承了虛擬方法 Bark
bunny.Bark();
*/