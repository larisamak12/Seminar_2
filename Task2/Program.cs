﻿// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число ");
int num=Convert.ToInt32(Console.ReadLine());


if(num >99 )
{
    int num1=num%10;
    Console.WriteLine($"Последняя цифра числа {num} равна {num1}");
    
}

else
{
    Console.WriteLine("Последняя цифра отсутствует");
}
