/*
本節文章
https://learnscript.net/zh-hant/programming/part-1/operator-overloading/ 什麽是運算子多載
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
        // 作業目標為整型，將雇員的年齡與其相加
        return employee.Age + age;
    }

    public static string operator +(Employee employee, string name)
    {
        // 作業目標為字串，將雇員的姓名與其相加
        return employee.Name + name;
    }
}

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

/// 建立執行個體，初始化雇員姓名和年齡
Employee employee = new("小小", 20);

/// 計算雇員 1 年後的年齡
Console.WriteLine($"一年後 {employee.Name + "先生"} 的年齡為 {employee.Age + 1}");
*/