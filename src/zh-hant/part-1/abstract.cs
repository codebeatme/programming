/*
本節視頻
https://www.bilibili.com/video/BV1ah411E7vN/ 「程式設計指南」什麽是抽象類別和抽象方法？抽象方法的限製，可抽象成員還有哪些

本節文章
https://learnscript.net/zh-hant/programming/part-1/abstract-classes-and-methods/ 什麽是抽象類別，抽象方法
*/

/*
以下程式碼與 override.cs，virtual.cs 只能有一個不被註解

/// 基礎類別 Animal，具有抽象方法，因此是抽象類別
abstract class Animal
{
    // 抽象方法 Bark，提供動物們發聲的功能
    public abstract void Bark();

    // public abstract int Age{
    //     get; set;
    // }
}

/// 衍生類別 Kitty
class Kitty : Animal
{
    // 實現 Animal 的抽象方法 Bark
    public override void Bark()
    {
        Console.WriteLine("小貓小貓，喵喵喵！");
    }
}

/// 衍生類別 Herbivore，沒有實現抽象方法 Bark，因此也是抽象類別
abstract class Herbivore : Animal
{ }
*/

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

/// 建立 Kitty 類別和 Herbivore 類別的執行個體
Kitty k1 = new Kitty();
Herbivore h1 = new Herbivore();

/// 呼叫 Bark 方法
k1.Bark();
h1.Bark();
*/