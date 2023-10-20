/*
本节文章
https://learnscript.net/zh/programming/part-2/callbacks/ 什么是回调
*/

// 类 Person，表示某个人
class Person
{
    // 字段姓名和年龄
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

/*
// 请将以下代码复制到 Program.cs 中，以运行本节示例

// GetPerson 是一个耗时的函数，我们将创建新的线程来执行他
void GetPerson(object? callback)
{
    // 为了看到效果，这里等待 3 秒
    Thread.Sleep(3000);
    Person tom = new("汤姆", 7);

    // 使用 callback 通知线程的创建者
    (callback as Action<Person>)?.Invoke(tom);
}

// 函数 DoSomething 用来做点什么
void DoSomething(Person person)
{

    // 不同的年龄有不同的安排
    if (person.Age > 100)
        Console.WriteLine($"{person.Name} 今天要去幽灵俱乐部");
    else if (person.Age > 20)
        Console.WriteLine($"{person.Name} 今天要工作");
    else if (person.Age > 6)
        Console.WriteLine($"{person.Name} 今天要上学");
    else
        Console.WriteLine($"{person.Name} 只会玩玩玩！");

}

// 创建线程执行 GetPerson，并将 DoSomething 作为回调目标
Thread thread = new(new ParameterizedThreadStart(GetPerson));
thread.Start(new Action<Person>(DoSomething));

Console.WriteLine("开启了一个新的线程");
*/