/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

// num 是實值型別變數
int num = 123;
// something 是參考型別變數，因此需要裝箱
object something = num;
// age 是實值型別變數，因此需要取消裝箱
int age = (int)something;

int num1 = 100;
// 以傳址的方式，將 num1 指派給 num2
ref int num2 = ref num1;
// 對 num2 指派，等同於對 num1 指派
num2 = 200;
Console.WriteLine($"num1={num1}");
*/