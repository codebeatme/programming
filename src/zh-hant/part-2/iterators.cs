/*
本節文章
https://learnscript.net/zh-hant/programming/part-2/iterators/ 什麽是疊代器
*/

/// 類別 Name，表示姓名，實現了疊代器功能
class Name : System.Collections.IEnumerator
{
    /// 一個人的全名，依次為名，中間名，姓
    public string FirstName = "<預設名>";
    public string SecondName = "<預設中間名>";
    public string LastName = "<預設姓>";

    /// 當前位置
    private int position = -1;

    /// 取得當前位置的元素的內容，可能是名，中間名或姓
    public object Current
    {
        get
        {
            if (position == 0)
                return FirstName;
            else if (position == 1)
                return SecondName;
            else if (position == 2)
                return LastName;
            else
                return string.Empty;
        }
    }

    /// 進入下一個元素的位置
    public bool MoveNext()
    {
        position++;

        // 已經是最後的元素
        if (position > 2)
            return false;

        return true;
    }

    /// 重置位置
    public void Reset()
    {
        position = -1;
    }

    ///
}

/*
請將以下程式碼復製到 Program.cs 中，以執行本節範例

/// 建立 Name 的執行個體，並設定名，中間名和姓
Name name = new()
{
    FirstName = "湯姆",
    SecondName = "彼得",
    LastName = "史密斯"
};

/// 顯示 Name 包含的三個元素，名，中間名和姓
while (name.MoveNext())
    Console.WriteLine(name.Current);
*/