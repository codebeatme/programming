// 变量 total，用于保存计算结果
int total = 0;

// 函数 sum，进行加法计算
void sum(int num)
{
    // 函数内可以访问函数外的变量 total
    total += num;
}

// 调用 sum
sum(7);
sum(9);

Console.WriteLine($"结果为：{total}");