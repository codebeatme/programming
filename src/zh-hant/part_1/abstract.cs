/*
本節文章
https://learnscript.net/zh-hant/programming/part-1/abstract-classes-and-methods/ 什麽是抽象類別，抽象方法
*/

/*
// 以下程式碼與 method_overriding.cs，virtual_methods.cs 只能有一個不被註解

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
    // 實作 Animal 的抽象方法 Bark
    public override void Bark()
    {
        Console.WriteLine("小貓小貓，喵喵喵！");
    }
}

/// 衍生類別 Herbivore，沒有實作抽象方法 Bark，因此也是抽象類別
abstract class Herbivore : Animal
{ }
*/