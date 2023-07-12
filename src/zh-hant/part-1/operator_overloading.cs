/*
本節視頻
https://www.bilibili.com/video/BV1Vc411J7rH/ 「程式設計指南」什麽是運算子多載？運算子多載的作用

被多載的運算子可以根據操作目標的型別，實現不同的運算

說明
“上一節說明了類別屬性”中的類別屬性應理解為指代類別的屬性，而不是與靜態屬性等同的類別屬性

版本
.NET 7.0.2
VSCode 1.77.3

相關視頻
https://www.bilibili.com/video/BV1Yv4y1H7BR/ 什麽是運算子？運算子的分類和優先順序
https://www.bilibili.com/video/BV18o4y1b7Y2/ 什麽是方法多載？如何呼叫多載方法？可多載成員還有哪些

關於本系列教程的使用說明和相關問題解答，請參考文章 https://www.bilibili.com/read/cv23041317
*/

/// 類別 Employee，表示雇員
class Employee
{
    /// 欄位 Name，Age 表示姓名和年齡
    public string Name;
    public int Age;

    /// 建構方法，初始化欄位 Name，Age
    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
    }

    /// 多載運算子 +
    public static int operator +(Employee employee, int age)
    {
        // 操作目標為整型，將雇員的年齡與其相加
        return employee.Age + age;
    }

    public static string operator +(Employee employee, string name)
    {
        // 操作目標為字串，將雇員的姓名與其拼接
        return employee.Name + name;
    }
}

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

/// 建立執行個體，初始化雇員姓名和年齡
Employee e = new Employee(
    "小小", 20
    );

/// 計算雇員 1 年後的年齡
Console.WriteLine(
    $"一年後 {e.Name + "先生"} 的年齡為 {e.Age + 1}"
    );
*/