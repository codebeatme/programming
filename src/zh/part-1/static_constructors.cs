/*
本节文章
https://learnscript.net/zh/programming/part-1/class-static-constructors-and-call/ 什么是类的静态构造方法？何时被调用
*/

// 一个关于学校的类
class School
{
    /// 静态字段，表示通过 School 类创建了多少学生
    public static int StudentCount;

    /// 静态构造方法，在 School 类被使用前调用
    static School()
    {
        StudentCount = 0;

        Console.WriteLine("School 的静态构造方法被调用");
    }

    /// 静态方法，创建一个随机的学生
    public static Student CreateStudent()
    {
        const string CHARS = "花明刚红黑";

        int i = Random.Shared.Next(0, CHARS.Length);

        // 随机的姓名和年龄
        Student student = new(
            $"小{CHARS[i]}",
            Random.Shared.Next(10, 20)
            );

        // 学生数量加 1
        StudentCount++;
        return student;
    }

    ///
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 创建 3 个 Student 类的实例
Student student1 = School.CreateStudent();
Student student2 = School.CreateStudent();
Student student3 = School.CreateStudent();

/// 显示学生的姓名和年龄
Console.WriteLine($"Name={student1.Name}，Age={student1.Age}");
Console.WriteLine($"Name={student2.Name}，Age={student2.Age}");
Console.WriteLine($"Name={student3.Name}，Age={student3.Age}");

/// 显示学生的数量
Console.WriteLine($"一共有学生 {School.StudentCount} 个");
*/