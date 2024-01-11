// 所有变量的类型均为 A，但真实的对象类型分别为 A，B，C，D
A a = new A();
A b = new B();
A c = new C();
A d = new D();

// 分别调用他们的 Show 方法
a.Show();
b.Show();
c.Show();
d.Show();