/*
本節視頻
https://www.bilibili.com/video/BV1ta4y1P73Z/ 「程式設計指南」什麽是存取層級？私用，保護和公用存取層級的區別，以及存取層級的拓展

本節文章
https://learnscript.net/zh-hant/programming/part-1/access-levels-private-protected-public/ 什麽是存取層級？私用，保護，公用存取層級有何不同
*/

/// 基礎類別 Device
class Device
{
    // 欄位 id
    // public Guid id = Guid.NewGuid();
    // protected Guid id = Guid.NewGuid();
    private Guid id = Guid.NewGuid();

    // 方法 Show 可以存取欄位 id
    public virtual void Show()
    {
        Console.WriteLine($"設備ID {id}");
    }
}

/// 衍生類別 Phone
class Phone : Device
{
    // Guid GetID()
    // {
    //     // ERROR 欄位 id 無法被存取
    //     return id;
    // }
}

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

Device device = new Device();
// ERROR 欄位 id 無法被存取
device.id = Guid.NewGuid();
*/