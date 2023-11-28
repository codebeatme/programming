/*
本节文章
https://learnscript.net/zh/programming/part-1/abstract-classes-and-methods/ 什么是抽象类，抽象方法
*/

/*
// 以下代码与 method_overriding.cs，virtual_methods.cs 只能有一个不被注释

/// 基类 Animal，具有抽象方法，因此是抽象类
abstract class Animal
{
    // 抽象方法 Bark，提供动物们发声的功能
    public abstract void Bark();

    // public abstract int Age{
    //     get; set;
    // }
}

/// 派生类 Kitty
class Kitty : Animal
{
    // 实现 Animal 的抽象方法 Bark
    public override void Bark()
    {
        Console.WriteLine("小猫小猫，喵喵喵！");
    }
}

/// 派生类 Herbivore，没有实现抽象方法 Bark，因此也是抽象类
abstract class Herbivore : Animal
{ }
*/