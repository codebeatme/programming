/*
本节视频
https://www.bilibili.com/video/BV1Az4y1a715/ 「编程指南」什么是接口的多重继承

和类一样，接口也具有多重继承的特性

版本
.NET 7.0.2
VSCode 1.77.3

相关视频
https://www.bilibili.com/video/BV1FV4y1d7pq/ 什么是接口的显式实现和隐式实现？显式实现和隐式实现的区别，显式实现的作用
https://www.bilibili.com/video/BV1Va4y1P7Hp/ 什么是多重继承？什么是多级继承？多重继承和多继承是否相同

关于本系列教程的使用说明和相关问题解答，请参考文章 https://www.bilibili.com/read/cv23041317
*/

/// 表示可播放的接口
interface IPlayable
{
    void Play();
}

/// 表示可停止的接口
interface IStoppable
{
    void Stop();
}

/// 表示可控制的接口，同时继承 IPlayable, IStoppable
interface IControllable : IPlayable, IStoppable
{ }

/// 类 Player 实现接口 IControllable
class Player : IControllable
{
    // 实现接口的方法 Play
    public void Play()
    {
        Console.WriteLine($"开始播放了哦！");
    }

    // 实现接口的方法 Stop
    public void Stop()
    {
        Console.WriteLine($"停止播放！");
    }
}