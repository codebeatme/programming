/*
本节文章
https://learnscript.net/zh/programming/part-1/operator-overloading/ 什么是运算符重载
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
        // 操作目标为字符串，将雇员的姓名与其相加
        return employee.Name + name;
    }
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 创建实例，初始化雇员姓名和年龄
Employee employee = new("小小", 20);

/// 计算雇员 1 年后的年龄
Console.WriteLine($"一年后 {employee.Name + "先生"} 的年龄为 {employee.Age + 1}");
*/