// 關於員工的類別 Employee
class Employee
{
    // 類別欄位 Count，記錄建立過的 Employee 執行個體的個數
    public static int Count;
    // 欄位 name，表示員工姓名
    string name;
    // 欄位 level，表示員工工資層級
    protected int level;

    // 屬性 Name，用於控製欄位 name 的存取
    public string Name
    {
        get { return name; }
        set
        {
            // 員工姓名不接受沒有意義的字串
            if (string.IsNullOrEmpty(name))
                return;

            name = value;
            Console.WriteLine($"員工改名為：{name}");
        }
    }

    // 方法 Evaluate，根據工作量評定員工的工資層級
    public void Evaluate(int workload)
    {
        level = workload / 365;
        Console.WriteLine($"員工 {Name} 的工資層級為：{level}");
    }

    // 建構子，用於初始化員工
    public Employee(string n)
    {
        // 建立過的 Employee 執行個體的個數加 1
        Count++;
        // 初始化員工姓名
        name = n;
    }
}

// 關於管理者的類別 Manager
class Manager : Employee
{

    // Manager 類別加入了新的方法 Manage
    public void Manage()
    {
        // 存取基礎類別的非私用成員
        Console.WriteLine($"{Name} 來管理自己了，哦，看下工資層級？{level}");
    }

    // 建構子，用於初始化管理者
    public Manager(string n) : base(n)
    { }

}

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

// 具現化類別 Employee
Employee employee = new("小熊貓");
// 通過屬性修改員工姓名
employee.Name = "浣熊";
// 使用年工作量 12345 評定員工
employee.Evaluate(12345);
// 顯示建立過的 Employee 執行個體的個數
Console.WriteLine($"建立了 {Employee.Count} 個 Employee");

// 具現化類別 Manager
Manager manager = new("老熊貓");
// 呼叫 Manager 類別定義的 Manage 方法
manager.Manage();
*/