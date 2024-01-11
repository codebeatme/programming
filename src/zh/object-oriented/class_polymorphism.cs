// 基类 Animal
abstract class Animal
{
    // 虚方法 Bark，尝试发出声音
    public virtual void Bark()
    {
        Console.WriteLine("试着发出声音？");
    }
    // 抽象方法 Run，奔跑起来
    public abstract void Run();
}

// 派生类 Kitty
class Kitty : Animal
{
    // Kitty 重写了继承自 Animal 的方法 Bark
    public override void Bark()
    {
        // 调用基类的 Bark 方法
        base.Bark();

        Console.WriteLine("喵喵喵！");
    }
    // Kitty 必须实现抽象方法 Run，才能被实例化
    public override void Run()
    {
        Console.WriteLine("你看，我跑起来了！");
    }
    // 使用重载定义两个同名的 Eat 方法
    public void Eat(string something)
    {
        Console.WriteLine($"好耶，今天的午餐是：{something}");
    }
    public void Eat()
    {
        Console.WriteLine("今天吃空气？！");
    }
}

// 类 A
class A
{
    // 虚方法 Show
    public virtual void Show()
    {
        Console.WriteLine("调用了 A 的 Show 方法");
    }
}

// 类 B
class B : A
{
    // 重写类 A 的 Show 方法
    public override void Show()
    {
        Console.WriteLine("调用了 B 的 Show 方法");
    }
}

// 类 C
class C : B
{
    // 隐藏类 B 的 Show 方法，阻断了继承关系
    public new virtual void Show()
    {
        Console.WriteLine("调用了 C 的 Show 方法");
    }
}

// 类 D
class D : C
{
    // 重写类 C 的 Show 方法
    public override void Show()
    {
        Console.WriteLine("调用了 D 的 Show 方法");
    }
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// 创建 Animal 和 Kitty 的实例
Animal animal = new Animal();
Animal kitty = new Kitty();

// 分别调用 Bark 方法，将显示不同信息
Console.WriteLine("animal.Bark");
animal.Bark();
Console.WriteLine("kitty.Bark");
kitty.Bark();

// 创建 Kitty 的实例
Kitty kitty = new Kitty();

// 调用 Run 方法
kitty.Run();

// 创建 Kitty 的实例
Kitty kitty = new Kitty();

// 调用重载的 Eat 方法
kitty.Eat("小鱼干");
kitty.Eat();
*/