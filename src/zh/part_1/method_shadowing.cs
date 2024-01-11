/*
本节文章
https://learnscript.net/zh/programming/part-1/method-shadowing/ 什么是方法隐藏？隐藏和重写有何不同
*/

// /// 类 A
// class A
// {
//     public virtual void Show(string text)
//     {
//         Console.WriteLine($"{text} 调用了 A 的 Show 方法");
//     }

//     // public virtual int Count
//     // {
//     //     get;
//     // }
// }

// /// 类 B
// class B : A
// {
//     public override void Show(string text)
//     {
//         Console.WriteLine($"{text} 调用了 B 的 Show 方法");
//     }

//     // public new int Count
//     // {
//     //     get;
//     // }
// }

// /// 类 C
// class C : B
// {
//     public new virtual void Show(string text)
//     // public override void Show(string text)
//     {
//         Console.WriteLine($"{text} 调用了 C 的 Show 方法");
//     }
// }

// /// 类 D
// class D : C
// {
//     public override void Show(string text)
//     {
//         Console.WriteLine($"{text} 调用了 D 的 Show 方法");
//     }
// }

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// 指定变量类型为类 A，但值的类型分别为类 A，B，C，D
A a1 = new A();
A a2 = new B();
A a3 = new C();
A a4 = new D();

// 分别调用他们的 Show 方法
a1.Show("A a1 = new A();...");
a2.Show("A a2 = new B();...");
a3.Show("A a3 = new C();...");
a4.Show("A a4 = new D();...");
*/