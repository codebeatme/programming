'他们的年龄为 12，8，13，102'.match(/\d\d/g)
// 匹配结果：['12', '13', '10']

'你好 吗？\r\n 不好！'.match(/.\s./g)
// 匹配结果：['好 吗']

'I like this c__, what ab__t you?'.match(/\w\w\w\w/g)
// 匹配结果：['like', 'this', 'what', 'ab__']

'like live li*e libe lie'.match(/li[kv*?]e/g)
// 匹配结果：['like', 'live', 'li*e']

'like live li*e libe lie'.match(/li[^c-z*]e/g)
// 匹配结果：['libe']

'%晚餐好了吗？%#还是出去吃吧#%不错的主意#'.match(/([%#])[^%#]*\1/g)
// 匹配结果：['%晚餐好了吗？%', '#还是出去吃吧#']

':%晚餐好了吗？%#还是出去吃吧#'.match(/(:([%#]))[^%#]*\2/g)
// 匹配结果：[':%晚餐好了吗？%']

'他说:%晚餐好了嗎？%'.replace(/:([%#])([^%#]*)(\1)/g, '：“$2”')
// 替换结果：'他说：“晚餐好了嗎？”'

'I live here'.match(/\blive\B/g)
// 匹配结果：null

'iPad 7 iPhone 11 iPad 9 Windows 7 iPhone 7'.match(/[a-zA-Z]+\b(?! 7)/g)
// 匹配结果：['iPhone', 'iPad']

'The apple is...\r\nThe orange is...'.match(/(?<=^The\s)\w+/gm)
// 匹配结果：['apple', 'orange']

'wo woo wooo woooo'.match(/\bwo{2,3}\b/g)
// 匹配结果：['woo', 'wooo']

'foo foo-foo foo-foo-foo'.match(/(-?foo){2,}/g)
// 匹配结果：['foo-foo', 'foo-foo-foo']

'I love you, I hate you'.match(/I (?:love|like) you/g)
// 匹配结果：['I love you']

'No, because nothing.Yes.No'.match(/Yes\.|No\b.*?\bbecause\b\s+([^.]+)\./g)
// 匹配结果：['No, because nothing.', 'Yes.']