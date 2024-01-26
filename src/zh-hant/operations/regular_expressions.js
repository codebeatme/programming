'他們的年齡為 12，8，13，102'.match(/\d\d/g)
// 比對結果：['12', '13', '10']

'你好 嗎？\r\n 不好！'.match(/.\s./g)
// 比對結果：['好 嗎']

'I like this c__, what ab__t you?'.match(/\w\w\w\w/g)
// 比對結果：['like', 'this', 'what', 'ab__']

'like live li*e libe lie'.match(/li[kv*?]e/g)
// 比對結果：['like', 'live', 'li*e']

'like live li*e libe lie'.match(/li[^c-z*]e/g)
// 比對結果：['libe']

'%晚餐好了嗎？%#還是出去吃吧#%不錯的主意#'.match(/([%#])[^%#]*\1/g)
// 比對結果：['%晚餐好了嗎？%', '#還是出去吃吧#']

':%晚餐好了嗎？%#還是出去吃吧#'.match(/(:([%#]))[^%#]*\2/g)
// 比對結果：[':%晚餐好了嗎？%']

'他說:%晚餐好了嗎？%'.replace(/:([%#])([^%#]*)(\1)/g, '：“$2”')
// 取代結果：'他說：“晚餐好了嗎？”'

'I live here'.match(/\blive\B/g)
// 比對結果：null

'iPad 7 iPhone 11 iPad 9 Windows 7 iPhone 7'.match(/[a-zA-Z]+\b(?! 7)/g)
// 比對結果：['iPhone', 'iPad']

'The apple is...\r\nThe orange is...'.match(/(?<=^The\s)\w+/gm)
// 比對結果：['apple', 'orange']

'wo woo wooo woooo'.match(/\bwo{2,3}\b/g)
// 比對結果：['woo', 'wooo']

'foo foo-foo foo-foo-foo'.match(/(-?foo){2,}/g)
// 比對結果：['foo-foo', 'foo-foo-foo']

'I love you, I hate you'.match(/I (?:love|like) you/g)
// 比對結果：['I love you']

'No, because nothing.Yes.No'.match(/Yes\.|No\b.*?\bbecause\b\s+([^.]+)\./g)
// 比對結果：['No, because nothing.', 'Yes.']