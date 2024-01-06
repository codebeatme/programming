/*
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
請將以下程式碼複製到 Program.cs 中，以執行本節範例

Device device = new();
// ERROR 欄位 id 無法被存取
device.id = Guid.NewGuid();
*/