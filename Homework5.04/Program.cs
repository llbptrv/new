﻿//Задана последовательность натуральных чисел, завершающаяся числом 0. 
//Требуется определить значение второго по величине элемента в этой последовательности, то есть элемента, 
//который будет наибольшим, если из последовательности удалить наибольший элемент.
//Гарантируется, что во входных данных не более 100 чисел и среди них есть хотя бы одно число 0, перед которым идет как минимум 2 элемента.

Console.WriteLine("введите число");
int n= Convert.ToInt32(Console.ReadLine());
int max=n;
int max2=0;

while(n!=0)
{
    n= Convert.ToInt32(Console.ReadLine());
    if (n>max)
    {
        max2=max;
        max=n;
    }
    else if (n>max2)
    {
        max2=n;
    }
   
}
Console.WriteLine(max2);