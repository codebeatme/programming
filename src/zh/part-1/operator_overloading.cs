/*
本节视频
https://www.bilibili.com/video/BV1Vc411J7rH/ 「编程指南」什么是运算符重载？运算符重载的作用

被重载的运算符可以根据操作目标的类型，实现不同的运算

说明
“上一节说明了类属性”中的类属性应理解为指代类的属性，而不是与静态属性等同的类属性

版本
.NET 7.0.2
VSCode 1.77.3

相关视频
https://www.bilibili.com/video/BV1Yv4y1H7BR/ 什么是运算符？运算符的分类和优先级
https://www.bilibili.com/video/BV18o4y1b7Y2/ 什么是方法重载？如何调用重载方法？可重载成员还有哪些

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// 类 Employee，表示雇员
class Employee
{
    /// 字段 Name，Age 表示姓名和年龄
    public string Name;
    public int Age;

    /// 构造方法，初始化字段 Name，Age
    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
    }

    /// 重载运算符 +
    public static int operator +(Employee employee, int age)
    {
        // 操作目标为整型，将雇员的年龄与其相加
        return employee.Age + age;
    }

    public static string operator +(Employee employee, string name)
    {
        // 操作目标为字符串，将雇员的姓名与其拼接
        return employee.Name + name;
    }
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 创建实例，初始化雇员姓名和年龄
Employee e = new Employee(
    "小小", 20
    );

/// 计算雇员 1 年后的年龄
Console.WriteLine(
    $"一年后 {e.Name + "先生"} 的年龄为 {e.Age + 1}"
    );
*/