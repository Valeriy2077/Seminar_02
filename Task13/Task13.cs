﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

System.Console.WriteLine("Введите число :");

int num = Convert.ToInt32(Console.ReadLine());
string NumText = Convert.ToString(num);
if (NumText.Length > 2){
  Console.WriteLine("третья цифра =  " + NumText[2]);
}
else {
  Console.WriteLine("нет третьей цифры");
}