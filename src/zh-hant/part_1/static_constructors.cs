/*
本節文章
https://learnscript.net/zh-hant/programming/part-1/class-static-constructors-and-call/ 什麽是類別的靜態建構方法？何時被呼叫
*/

// 一個關於學校的類別
class School
{
    /// 靜態欄位，表示通過 School 類別建立了多少學生
    public static int StudentCount;

    /// 靜態建構方法，在 School 類別被使用前呼叫
    static School()
    {
        StudentCount = 0;

        Console.WriteLine("School 的靜態建構方法被呼叫");
    }

    /// 靜態方法，建立一個隨機的學生
    public static Student CreateStudent()
    {
        const string CHARS = "花明剛紅黑";

        int i = Random.Shared.Next(0, CHARS.Length);

        // 隨機的姓名和年齡
        Student student = new(
            $"小{CHARS[i]}",
            Random.Shared.Next(10, 20)
            );

        // 學生數量加 1
        StudentCount++;
        return student;
    }

    ///
}

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

/// 建立 3 個 Student 類別的執行個體
Student student1 = School.CreateStudent();
Student student2 = School.CreateStudent();
Student student3 = School.CreateStudent();

/// 顯示學生的姓名和年齡
Console.WriteLine($"Name={student1.Name}，Age={student1.Age}");
Console.WriteLine($"Name={student2.Name}，Age={student2.Age}");
Console.WriteLine($"Name={student3.Name}，Age={student3.Age}");

/// 顯示學生的數量
Console.WriteLine($"一共有學生 {School.StudentCount} 個");
*/