/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// num 是值类型变量
int num = 123;
// something 是引用类型变量，因此需要装箱
object something = num;
// age 是值类型变量，因此需要取消装箱
int age = (int)something;

int num1 = 100;
// 以引用传递的方式，将 num1 赋值给 num2
ref int num2 = ref num1;
// 对 num2 赋值，等同于对 num1 赋值
num2 = 200;
Console.WriteLine($"num1={num1}");
*/