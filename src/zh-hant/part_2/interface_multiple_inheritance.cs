/*
本節文章
https://learnscript.net/zh-hant/programming/part-2/interface-multiple-inheritance/ 什麽是介面的多重繼承
*/

/// 介面 IPlayable，表示可播放
interface IPlayable
{
    void Play();
}

/// 介面 IStoppable，表示可停止
interface IStoppable
{
    void Stop();
}

/// 介面 IControllable，同時繼承 IPlayable, IStoppable，表示可控製
interface IControllable : IPlayable, IStoppable
{ }

/// 類別 Player，實作介面 IControllable
class Player : IControllable
{
    // 實作介面的方法 Play
    public void Play()
    {
        Console.WriteLine("開始播放了哦！");
    }

    // 實作介面的方法 Stop
    public void Stop()
    {
        Console.WriteLine("停止播放！");
    }
}