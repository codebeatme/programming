// 基底類別 Animal
abstract class Animal
{
    // 虛擬方法 Bark，嘗試發出聲音
    public virtual void Bark()
    {
        Console.WriteLine("試著發出聲音？");
    }
    // 抽象方法 Run，奔跑起來
    public abstract void Run();
}

// 衍生類別 Kitty
class Kitty : Animal
{
    // Kitty 覆寫了繼承自 Animal 的方法 Bark
    public override void Bark()
    {
        // 呼叫基底類別的 Bark 方法
        base.Bark();

        Console.WriteLine("喵喵喵！");
    }
    // Kitty 必須實作抽象方法 Run，才能被具現化
    public override void Run()
    {
        Console.WriteLine("你看，我跑起來了！");
    }
    // 使用多載定義兩個同名的 Eat 方法
    public void Eat(string something)
    {
        Console.WriteLine($"好耶，今天的午餐是：{something}");
    }
    public void Eat()
    {
        Console.WriteLine("今天吃空氣？！");
    }
}

// 類別 A
class A
{
    // 虛擬方法 Show
    public virtual void Show()
    {
        Console.WriteLine("呼叫了 A 的 Show 方法");
    }
}

// 類別 B
class B : A
{
    // 覆寫類別 A 的 Show 方法
    public override void Show()
    {
        Console.WriteLine("呼叫了 B 的 Show 方法");
    }
}

// 類別 C
class C : B
{
    // 遮蔽類別 B 的 Show 方法，阻斷了繼承關系
    public new virtual void Show()
    {
        Console.WriteLine("呼叫了 C 的 Show 方法");
    }
}

// 類別 D
class D : C
{
    // 覆寫類別 C 的 Show 方法
    public override void Show()
    {
        Console.WriteLine("呼叫了 D 的 Show 方法");
    }
}

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

// 建立 Animal 和 Kitty 的執行個體
Animal animal = new Animal();
Animal kitty = new Kitty();

// 分別呼叫 Bark 方法，將顯示不同資訊
Console.WriteLine("animal.Bark");
animal.Bark();
Console.WriteLine("kitty.Bark");
kitty.Bark();

// 建立 Kitty 的執行個體
Kitty kitty = new Kitty();

// 呼叫 Run 方法
kitty.Run();

// 建立 Kitty 的執行個體
Kitty kitty = new Kitty();

// 呼叫多載的 Eat 方法
kitty.Eat("小魚幹");
kitty.Eat();

// 所有變數的型別均為 A，但真實的物件型別分別為 A，B，C，D
A a = new A();
A b = new B();
A c = new C();
A d = new D();

// 分別呼叫他們的 Show 方法
a.Show();
b.Show();
c.Show();
d.Show();
*/