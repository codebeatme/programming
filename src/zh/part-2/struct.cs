/*
本节视频
https://www.bilibili.com/video/BV1gM411G7EX/ 「编程指南」什么是结构？结构和类的区别，结构与值类型变量

结构和类一样，会包含数据或信息，并将其存储在字段中
* 一些语言中的结构，会支持更多的特性，比如，方法
* 结构一般被存储在值类型变量中

版本
.NET 7.0.2
VSCode 1.77.3

相关视频
https://www.bilibili.com/video/BV1Dm4y1B7gi/ 什么是数据类型？数字类型和字符串类型的区别
https://www.bilibili.com/video/BV1bo4y1879U/ 什么是类？什么是对象和实例？类和对象实例的区别
https://www.bilibili.com/video/BV1cM411G7VC/ 什么是值类型变量？什么是引用型变量？有什么区别

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// 结构 Book，表示书籍的相关信息
struct Book
{
    /// 字段 Name 表示书名，ISBN 表示书号
    public string Name;
    public string ISBN;

    /// 方法 ShowInfo，显示书籍的信息
    public void ShowInfo()
    {
        Console.WriteLine($"书名 {Name}，书号 {ISBN}");
    }

    /// 静态成员，与书籍的总数量相关
    public static int Count = 0;
    public static void ShowCount()
    {
        Console.WriteLine($"书籍总数量为：{Count}");
    }
}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 创建结构，并通过 b1 赋值给 b2，b1 和 b2 存储了各自的结构
Book b1 = new Book()
{
    Name = "我是一本书",
    ISBN = "一个合理的书号"
};
Book b2 = b1;

/// 修改 b2 中的结构的字段
b2.Name = "这不是书";
b2.ISBN = "这不是书号";

/// b1 中的结构不受影响
b1.ShowInfo();
*/