/*
本节文章
https://learnscript.net/zh/programming/part-4/nested-types/ 什么是嵌套类型
*/

// // 类 Flower，表示一朵花
// class Flower
// {

//     // 嵌套类型 Color，用来表示花的颜色
//     enum Color
//     {
//         // 没有颜色
//         None = 0,
//         // 红色
//         Red = 1,
//         // 白色
//         White = 2,
//         // 蓝色
//         Blue = 3,
//     }

//     // 将 color 字段定义为私有
//     private Color color = Color.None;

//     public Flower()
//     {
//         // 随机的获取一种颜色
//         int i = new Random().Next(1, 4);

//         color = (Color)i;
//     }

//     // 显示是什么颜色的花
//     public void Show()
//     {

//         switch (color)
//         {
//             case Color.Red:
//                 Console.WriteLine("一朵红花");
//                 break;
//             case Color.White:
//                 Console.WriteLine("一朵白花");
//                 break;
//             case Color.Blue:
//                 Console.WriteLine("一朵蓝花");
//                 break;
//         }

//     }
// }

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

// 创建一朵颜色随机的花，并显示颜色
new Flower().Show();
*/