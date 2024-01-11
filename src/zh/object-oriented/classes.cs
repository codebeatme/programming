// 关于员工的类 Employee
class Employee
{
    // 类字段 Count，记录创建过的 Employee 实例的个数
    public static int Count;
    // 字段 name，表示员工姓名
    string name;
    // 字段 level，表示员工工资等级
    protected int level;

    // 属性 Name，用于控制字段 name 的访问
    public string Name
    {
        get { return name; }
        set
        {
            // 员工姓名不接受没有意义的字符串
            if (string.IsNullOrEmpty(name))
                return;

            name = value;
            Console.WriteLine($"员工改名为：{name}");
        }
    }

    // 方法 Evaluate，根据工作量评估员工的工资等级
    public void Evaluate(int workload)
    {
        level = workload / 365;
        Console.WriteLine($"员工 {Name} 的工资等级为：{level}");
    }

    // 构造器，用于初始化员工
    public Employee(string n)
    {
        // 由于类字段 Count 归属于类而非某个实例，因此会一直累计
        // 创建过的 Employee 实例的个数加 1
        Count++;
        // 初始化员工姓名
        name = n;
    }
}

// 关于管理者的类 Manager
class Manager : Employee
{

    // Manager 类加入了新的方法 Manage
    public void Manage()
    {
        // 访问基类的非私有成员
        Console.WriteLine($"{Name} 来管理自己了，哦，看下工资等级？{level}");
    }

    // 构造器，用于初始化管理者
    public Manager(string n) : base(n)
    { }

}

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// 实例化类 Employee
Employee employee1 = new("小熊猫");
// 通过属性修改员工姓名
employee1.Name = "浣熊";
// 使用年工作量 12345 评估员工
employee1.Evaluate(12345);
// 显示创建过的 Employee 实例的个数
Console.WriteLine($"创建了 {Employee.Count} 个 Employee");

// 再次实例化类 Employee
Employee employee2 = new("大熊猫");
// 此时显示的个数为 2
Console.WriteLine($"创建了 {Employee.Count} 个 Employee");

// 实例化类 Manager
Manager manager = new("老熊猫");
// 调用 Manager 类定义的 Manage 方法
manager.Manage();
*/