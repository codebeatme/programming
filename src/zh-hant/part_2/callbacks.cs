/*
本節文章
https://learnscript.net/zh-hant/programming/part-2/callbacks/ 什麽是回呼
*/

// 類別 Person，表示某個人
class Person
{
    // 欄位姓名和年齡
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

/*
// 請將以下程式碼複製到 Program.cs 中，以執行本節範例

// GetPerson 是一個耗時的函式，我們將建立新的執行緒來執行他
void GetPerson(object? callback)
{
    // 為了看到效果，這裏等待 3 秒
    Thread.Sleep(3000);
    Person tom = new("湯姆", 7);

    // 使用 callback 通知執行緒的建立者
    (callback as Action<Person>)?.Invoke(tom);
}

// 函式 DoSomething 用來做點什麽
void DoSomething(Person person)
{

    // 不同的年齡有不同的安排
    if (person.Age > 100)
        Console.WriteLine($"{person.Name} 今天要去幽靈俱樂部");
    else if (person.Age > 20)
        Console.WriteLine($"{person.Name} 今天要工作");
    else if (person.Age > 6)
        Console.WriteLine($"{person.Name} 今天要上學");
    else
        Console.WriteLine($"{person.Name} 只會玩玩玩！");

}

// 建立執行緒執行 GetPerson，並將 DoSomething 作為回呼目標
Thread thread = new(new ParameterizedThreadStart(GetPerson));
thread.Start(new Action<Person>(DoSomething));

Console.WriteLine("開啟了一個新的執行緒");
*/