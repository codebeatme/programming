/*
本节视频
https://www.bilibili.com/video/BV1Ah41157qo/ 「编程指南」什么是编码规范？编码规范的作用和分类

命名是代码编写中的一项重要工作，命名规范是针对命名的指导意见
* 名称不应包含不具普遍性的缩写
* 针对同一类内容，应使用风格一致的拼写方式
* 拼写方式主要有，大驼峰，小驼峰，蛇形和串烧

版本
Node.js 18.16.0
VSCode 1.78.0

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// 没人知道 sc 是什么东西，除了写他的人
var sc = 100

/// 大驼峰，单词的首字母大写，其余小写
class RedApple { }

/// 小驼峰，与大驼峰类似，但第一个字母小写
function createApple() { }

/// 蛇形，单词之间使用_连接
function get_red_apple() { }

/// 串烧，单词之间使用-连接，可见于 Vue 的文件夹命名

/// 全大写或全小写，以及多种方式的组合
const MAX = 10000
const MIN_COUNT = 1
