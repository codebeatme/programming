/*
本節文章
https://learnscript.net/zh-hant/programming/part-2/pointers/ 什麽是指針？指針和參考類型有何不同
*/

#include <iostream>

// 主函式
int main()
{
    /// 定義了一個表示年齡的陣列 ages
    int ages[] = {1, 2, 3, 4, 5};

    /// 定義指針變數 pointer，並指向陣列 ages
    int *pointer;
    pointer = ages;

    /// 顯示陣列中每一個元素的記憶體位址和值
    for (int i = 0; i < 5; i++)
    {
        // 使用 pointer 來顯示元素的記憶體位址
        std::cout << "ages[" << i << "] 的位址為 " << pointer << std::endl;
        // 使用 *pointer 來取值，也就是取得元素的值
        std::cout << "ages[" << i << "] 的值為 " << *pointer << std::endl;

        // 將指針移動到下一個元素的記憶體位址
        pointer++;
    }

    ///
}