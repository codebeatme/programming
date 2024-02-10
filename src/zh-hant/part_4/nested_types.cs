/*
本節文章
https://learnscript.net/zh-hant/programming/part-4/nested-types/ 什麽是巢狀型別
*/

// // 類別 Flower，表示一朵花
// class Flower
// {

//     // 巢狀型別 Color，用來表示花的色彩
//     enum Color
//     {
//         // 沒有色彩
//         None = 0,
//         // 紅色
//         Red = 1,
//         // 白色
//         White = 2,
//         // 藍色
//         Blue = 3,
//     }

//     // 將 color 欄位定義為私用
//     private Color color = Color.None;

//     public Flower()
//     {
//         // 隨機的取得一種色彩
//         int i = new Random().Next(1, 4);

//         color = (Color)i;
//     }

//     // 顯示是什麽色彩的花
//     public void Show()
//     {

//         switch (color)
//         {
//             case Color.Red:
//                 Console.WriteLine("一朵紅花");
//                 break;
//             case Color.White:
//                 Console.WriteLine("一朵白花");
//                 break;
//             case Color.Blue:
//                 Console.WriteLine("一朵藍花");
//                 break;
//         }

//     }
// }

/*
請將以下程式碼複製到 Program.cs 中，以執行本節範例

// 建立一朵色彩隨機的花，並顯示色彩
new Flower().Show();
*/