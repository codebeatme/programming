/*
本节文章
https://learnscript.net/zh/programming/part-3/optional-parameters/ 什么是可选参数
*/

/*
请将以下代码复制到 Program.cs 中，以运行本节示例

/// 显示欢迎消息的函数
void Welcome(
    string name,
    // message 是一个可选参数，拥有默认值 "你好！{0}"
    string message = "你好！{0}"
    )
{
    Console.WriteLine(message, name);
}

/// 可以不为可选参数 message 指定值
Welcome("大花猫");
*/