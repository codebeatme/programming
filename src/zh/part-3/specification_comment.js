/*
本节视频
https://www.bilibili.com/video/BV1Nm4y1h7JU/ 「编程指南」什么是注释？注释的作用，注释的规范和一般原则

注释可以解释代码的含义，帮助开发人员阅读或使用代码提供的功能
* 注释中的描述，应该简洁清晰
* 注释主要针对，关键，复杂，或提供对外功能的代码
* 修改代码后，应维护相关的注释，以免出现不正确的解释
* 注释可用于不再使用的代码
* 注释可用于生成快速提示

版本
Node.js 18.16.0
VSCode 1.78.0

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// 一段清晰简洁的描述？哦！

/// 这是一段非常关键的代码，( •̀ ω •́ )✧
let keyword = 10101010

/// 为类添加注释
class School {
    /**
     * 调用该方法，开始上课！
     */
    classBegin() { }
}

/// 以下代码被注释掉了
// message = '今天天气如何？'
// console.log(message)

/// 可用于快速提示的注释
/**
 * 出售一样物品
 * @param {string} item 需要出售的物品的名称
 */
function sellSomething(item) { }
