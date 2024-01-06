/*
本節文章
https://learnscript.net/zh-hant/programming/part-1/method-shadowing/ 什麽是方法遮蔽？遮蔽和覆寫有何不同
*/

/// 類別 A
class A
{
    public virtual void Show(string text)
    {
        Console.WriteLine($"{text} 呼叫了 A 的 Show 方法");
    }

    // public virtual int Count
    // {
    //     get;
    // }
}

/// 類別 B
class B : A
{
    public override void Show(string text)
    {
        Console.WriteLine($"{text} 呼叫了 B 的 Show 方法");
    }

    // public new int Count
    // {
    //     get;
    // }
}

/// 類別 C
class C : B
{
    public new virtual void Show(string text)
    // public override void Show(string text)
    {
        Console.WriteLine($"{text} 呼叫了 C 的 Show 方法");
    }
}

/// 類別 D
class D : C
{
    public override void Show(string text)
    {
        Console.WriteLine($"{text} 呼叫了 D 的 Show 方法");
    }
}

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

// 指定變數類型為類別 A，但值的類型分別為類別 A，B，C，D
A a1 = new A();
A a2 = new B();
A a3 = new C();
A a4 = new D();

// 分別呼叫他們的 Show 方法
a1.Show("A a1 = new A();...");
a2.Show("A a2 = new B();...");
a3.Show("A a3 = new C();...");
a4.Show("A a4 = new D();...");
*/