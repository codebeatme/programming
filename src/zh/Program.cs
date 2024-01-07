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