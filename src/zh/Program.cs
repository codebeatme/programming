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