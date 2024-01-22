// 類別 Flower，表示一朵花
class Flower
{
    // 巢狀類型 Color
    enum Color
    {
        // 沒有色彩
        None = 0,
        // 紅色
        Red = 1,
        // 白色
        White = 2,
        // 藍色
        Blue = 3,
    }

    // 欄位 Color，表示花的色彩，隨機產生
    private Color color = (Color)new Random().Next(1, 4);
    // …
}

// 命名空間 World.Animals
namespace World.Animals
{
	// 類別 Lion，表示獅子
	class Lion { }
}

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

// 變數 total，用於儲存計算結果
int total = 0;

// 函式 sum，進行加法計算
void sum(int num) {
    // 函式內可以存取函式外的變數 total
    total += num;
}

// 呼叫 sum
sum(7);
sum(9);

Console.WriteLine($"結果為：{total}");
*/