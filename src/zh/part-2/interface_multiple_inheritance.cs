/*
本节文章
https://learnscript.net/zh/programming/part-2/interface-multiple-inheritance/ 什么是接口的多重继承
*/

/// 接口 IPlayable，表示可播放
interface IPlayable
{
    void Play();
}

/// 接口 IStoppable，表示可停止
interface IStoppable
{
    void Stop();
}

/// 接口 IControllable，同时继承 IPlayable, IStoppable，表示可控制
interface IControllable : IPlayable, IStoppable
{ }

/// 类 Player，实现接口 IControllable
class Player : IControllable
{
    // 实现接口的方法 Play
    public void Play()
    {
        Console.WriteLine("开始播放了哦！");
    }

    // 实现接口的方法 Stop
    public void Stop()
    {
        Console.WriteLine("停止播放！");
    }
}