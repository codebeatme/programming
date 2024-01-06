/*
本節文章
https://learnscript.net/zh-hant/programming/part-2/enumerations/ 什麽是列舉？如何使用
*/

/// 列舉 LightColor，表示亮色
enum LightColor
{
    /// 第一個列舉成員，預設對應整數類型數值 0
    White,
    /// 後續成員對應的整數類型數值，依次遞增 1
    // 成員 Red = 1
    Red,
    // 成員 Green = 2
    Green,
    ///
}

/// 列舉 DarkColor，表示暗色
enum DarkColor
{
    /// 可以為成員指定其對應的整數類型數值
    Black = 100,
    Blue = 200,
    ///
}

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

/// 為列舉變數 color 指派
LightColor color = LightColor.Green;

/// 讀取列舉變數 color，並與列舉成員 Green 對比
if (color == LightColor.Green)
    Console.WriteLine("綠色讓眼睛感覺舒適！");
*/