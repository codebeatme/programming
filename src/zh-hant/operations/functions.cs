/*
// 顯示歡迎訊息的函式
void Welcome(string name, string message = "你好！{0}")
{
	Console.WriteLine(message, name);
}

// 可以不為選擇性參數 message 指定值
Welcome("大花貓");

// 顯示一組水果的函式
void ListFruit(params string[] list)
{
	Console.WriteLine($"一共有 {list.Length} 個水果");

	foreach (string fruit in list)
		Console.WriteLine(fruit);
}

// 傳遞多個引數
ListFruit(
	"一個橘子",
	"一個蘋果",
	"還是一個蘋果"
);

// 一個用於建立計劃的函式
void CreatePlan(string name, int days, string leader)
{
	// 顯示計劃的相關資訊
	Console.WriteLine($"計劃 {name}:");
	Console.WriteLine($"\t天數 {days}");
	Console.WriteLine($"\t領導 {leader}");
}

// 呼叫函式 CreatePlan，days 參數最後指派
CreatePlan(
	name: "搬家計劃",
	leader: "鏟屎官",
	days: 5
);

// 混合使用兩種方式為參數指派
CreatePlan(
	"另一個計劃",
	days: 100,
	"另一個鏟屎官"
);

// 一個用於計算加法的函式
int Sum(int a, int b)
{
	return a + b;
}

// 將陣列中所有非陣列元素視為整數，並計算他們的和
int SumArray(object[] array)
{
	int result = 0;

	// 迴圈陣列中的元素，如果是陣列，則呼叫 SumArray 自身
	foreach (object item in array)
	{
		if (item is object[] a)
			result += SumArray(a);
		else
			result += (int)item;
	}

	return result;
}

// 一個複雜的包含整數的陣列
object[] myArray = new object[] {
	new object[] { 1, 2 },
	10, 20,
	new object[] { 100, 200 },
};

// 呼叫 SumArray 進行計算
int myResult = SumArray(myArray);
Console.WriteLine($"計算結果為：{myResult}");

int result = Sum(1, 2);
Console.WriteLine($"1 加 2 的結果為 {result}");

// 建立 Cannon 類別的執行個體 cannon
Cannon cannon = new();

// 通過不同的參數，呼叫不同的 Attack 方法
// 呼叫第一個 Attack 方法
cannon.Attack(100);
// 呼叫第二個 Attack 方法
cannon.Attack(100, true);

// 類別 Cannon，表示加農炮
class Cannon
{
	// 第一個 Attack 方法，只有一個整數類型參數
	public void Attack(int point)
	{
		Console.WriteLine($"可造成 {point} 點傷害");
	}

	// 第二個 Attack 方法，有一個整數類型參數和一個布林類型參數
	public void Attack(int point, bool critical)
	{
		Console.WriteLine($"可造成 {point} 點傷害 [暴擊？{critical}]");
	}
}
*/