/*
// 显示欢迎消息的函数
void Welcome(
	string name,
	// message 是一个可选参数，拥有默认值 "你好！{0}"
	string message = "你好！{0}"
	)
{
	Console.WriteLine(message, name);
}

// 可以不为可选参数 message 指定值
Welcome("大花猫");

// 显示一组水果的函数
void ListFruit(
	// list 是一个可变参数
	params string[] list
	)
{
	Console.WriteLine($"一共有 {list.Length} 个水果");

	foreach (string fruit in list)
		Console.WriteLine(fruit);
}

// 传递多个实参
ListFruit(
	"一个橘子",
	"一个苹果",
	"还是一个苹果"
);

// 一个用于创建计划的函数
void CreatePlan(string name, int days, string leader)
{
	// 显示计划的相关信息
	Console.WriteLine($"计划 {name}:");
	Console.WriteLine($"\t天数 {days}");
	Console.WriteLine($"\t领导 {leader}");
}

// 调用函数 CreatePlan，days 参数最后赋值
CreatePlan(
	name: "搬家计划",
	leader: "铲屎官",
	days: 5
);

// 混合使用两种方式为参数赋值
CreatePlan(
	"另一个计划",
	days: 100,
	"另一个铲屎官"
);

// 一个用于计算加法的函数
int Sum(int a, int b)
{
	return a + b;
}

// 将数组中所有非数组元素视为整数，并计算他们的和
int SumArray(object[] array)
{
	int result = 0;

	// 循环数组中的元素，如果是数组，则调用 SumArray 自身
	foreach (object item in array)
	{
		if (item is object[] a)
			result += SumArray(a);
		else
			result += (int)item;
	}

	return result;
}

// 一个复杂的包含整数的数组
object[] myArray = new object[] {
	new object[] { 1, 2 },
	10, 20,
	new object[] { 100, 200 },
};

// 调用 SumArray 进行计算
int myResult = SumArray(myArray);
Console.WriteLine($"计算结果为：{myResult}");

int result = Sum(1, 2);
Console.WriteLine($"1 加 2 的结果为 {result}");

// 创建 Cannon 类的实例 cannon
Cannon cannon = new();

// 通过不同的参数，调用不同的 Attack 方法
// 调用第一个 Attack 方法
cannon.Attack(100);
// 调用第二个 Attack 方法
cannon.Attack(100, true);

// 类 Cannon，表示加农炮
class Cannon
{
	// 第一个 Attack 方法，只有一个整数类型参数
	public void Attack(int point)
	{
		Console.WriteLine($"可造成 {point} 点伤害");
	}

	// 第二个 Attack 方法，有一个整数类型参数和一个布尔类型参数
	public void Attack(int point, bool critical)
	{
		Console.WriteLine($"可造成 {point} 点伤害 [暴击？{critical}]");
	}
}
*/