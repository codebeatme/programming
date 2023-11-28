/*
本節文章
https://learnscript.net/zh-hant/programming/part-1/class-constructors/ 什麽是類別的建構方法
*/

// 一個關於學生的類別
class Student
{
    /// 欄位，學生姓名和年齡
    public string Name;
    public int Age;

    /// 建構方法，將參數 n，a 分別指派給姓名和年齡
    public Student(string n, int a)
    {
        Name = n;
        Age = a;
    }
}

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

/// 建立 Student 類別的執行個體
Student student = new("小明", 13);

/// 顯示學生資訊
Console.WriteLine($"Name={student.Name}，Age={student.Age}");
*/