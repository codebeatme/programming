/*
本节视频
https://www.bilibili.com/video/BV1bo4y1879U/ 「编程指南」什么是类？什么是对象和实例？类和对象实例的区别

本节文章
https://learnscript.net/zh/programming/part-1/classes-objects-instances/ 什么是类，对象，实例
*/

// 一个关于猫咪的类
class Cat
{
    /// 猫咪名字，出生日期
    public string? name;
    public DateTime birthdate;

    /// 计算猫咪的年龄
    public int GetAge()
    {
        TimeSpan span = DateTime.Now - birthdate;

        return Convert.ToInt32(span.TotalDays / 365);
    }

    ///
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 创建实例
Cat cat = new Cat();

/// 设置名字，出生日期
cat.name = "小花";
cat.birthdate = new DateTime(2020, 3, 1);

/// 显示年龄
Console.WriteLine(
    $"{cat.name} 今年 {cat.GetAge()} 岁了！"
    );
*/
