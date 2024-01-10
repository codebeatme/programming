// 实例化类 Employee
Employee employee = new("小熊猫");
// 通过属性修改员工姓名
employee.Name = "浣熊";
// 使用年工作量 12345 评估员工
employee.Evaluate(12345);
// 显示创建过的 Employee 实例的个数
Console.WriteLine($"创建了 {Employee.Count} 个 Employee");

// 实例化类 Manager
Manager manager = new("老熊猫");
// 调用 Manager 类定义的 Manage 方法
manager.Manage();