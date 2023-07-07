/*
本节视频
https://www.bilibili.com/video/BV14L411e7y6/ 「编程指南」什么是类的构造方法？构造方法的作用和命名

本节文章
https://learnscript.net/zh/programming/part-1/class-constructors/ 什么是类的构造方法
*/

// 一个关于学生的类
class Student
{
    /// 字段，学生姓名和年龄
    public string Name;
    public int Age;

    /// 构造方法，将参数 n，a 分别赋值给姓名和年龄
    public Student(string n, int a)
    {
        Name = n;
        Age = a;
    }
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 创建 Student 类的实例
Student student =
    new Student("小明", 13);

/// 显示学生信息
Console.WriteLine(
    $"Name = {student.Name}，Age = {student.Age}"
    );
*/