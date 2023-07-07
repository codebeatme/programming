/*
本节视频
https://www.bilibili.com/video/BV1ah411E7vN/ 「编程指南」什么是抽象类和抽象方法？抽象方法的限制，可抽象成员还有哪些

本节文章
https://learnscript.net/zh/programming/part-1/abstract-classes-and-methods/ 什么是抽象类，抽象方法
*/

/*
以下代码与 override.cs，virtual.cs 只能有一个不被注释

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

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 创建 Kitty 类和 Herbivore 类的实例
Kitty k1 = new Kitty();
Herbivore h1 = new Herbivore();

/// 调用 Bark 方法
k1.Bark();
h1.Bark();
*/