/*
本节文章
https://learnscript.net/zh/programming/part-1/method-overriding/ 什么是方法重写
*/

/*
// 以下代码与 abstract.cs，virtual_methods.cs 只能有一个不被注释

/// 基类 Animal
class Animal
{
    // 方法 Bark，默认为动物无法发声
    public virtual void Bark()
    {
        Console.WriteLine("抱歉，本动物无法发声");
    }
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

/// 创建 Kitty 和 Bunny 的实例
Kitty kitty = new();
Bunny bunny = new();

/// 分别调用 Bark 方法，将显示不同信息
kitty.Bark();
bunny.Bark();
*/