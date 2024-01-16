/*
本节文章
https://learnscript.net/zh/programming/part-2/structures/ 什么是结构？结构和类有何不同
*/

// /// 结构 Book，表示书籍的相关信息
// struct Book
// {
//     /// 字段 Name 表示书名，Isbn 表示书号
//     public string Name;
//     public string Isbn;

//     /// 方法 ShowInfo，显示书籍的信息
//     public void ShowInfo()
//     {
//         Console.WriteLine($"书名 {Name}，书号 {Isbn}");
//     }

//     /// 静态成员，与书籍的总数量相关
//     public static int Count = 0;
//     public static void ShowCount()
//     {
//         Console.WriteLine($"书籍总数量为：{Count}");
//     }
// }

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 创建结构，并通过 book1 赋值给 book2，book1 和 book2 存储了各自的结构
Book book1 = new()
{
    Name = "我是一本书",
    Isbn = "一个合理的书号"
};
Book book2 = book1;

/// 修改 book2 中的结构的字段
book2.Name = "这不是书";
book2.Isbn = "这不是书号";

/// book1 中的结构不受影响
book1.ShowInfo();
*/