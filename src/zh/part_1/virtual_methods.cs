/*
本节文章
https://learnscript.net/zh/programming/part-1/virtual-methods/ 什么是虚方法？虚和抽象方法有何不同
*/

/*
// 以下代码与 abstract.cs，method_overriding.cs 只能有一个不被注释

/// 基类 Animal
class Animal
{
    // 方法 Bark，默认为动物无法发声
    public virtual void Bark()
    {
        Console.WriteLine("抱歉，本动物无法发声");
    }

    // public virtual int Age {
    //     get;
    // }
}

/// 派生类 Kitty
class Kitty : Animal
{
    // 重写 Animal 的 Bark 方法，因为小猫可以发声
    public override void Bark()
    {
        Console.WriteLine("小猫小猫，喵喵喵！");
    }
}

/// 派生类 Bunny，直接继承 Animal 的 Bark 方法
class Bunny : Animal
{ }
*/

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 虚方法本身已经被实现，因此可以创建相关实例
Animal animal = new();
Kitty kitty = new();
Bunny bunny = new();

/// 调用 Bark 方法
animal.Bark();
// Kitty 重写了虚方法 Bark
kitty.Bark();
// Bunny 直接继承了虚方法 Bark
bunny.Bark();
*/