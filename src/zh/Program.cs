﻿// num 是值类型变量
int num = 123;
// something 是引用类型变量，因此需要装箱
object something = num;
// age 是值类型变量，因此需要取消装箱
int age = (int)something;