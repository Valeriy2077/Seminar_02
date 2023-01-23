// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели:");

int daynum = Convert.ToInt32(Console.ReadLine());

void checkday (int daynum) 
{

  if (daynum == 6 || daynum == 7)
  {

  Console.WriteLine("Этот день - выходной");

  }

  else if (daynum < 1 || daynum > 7) 
  {

    Console.WriteLine("Такого дня недели не существует");

  }

  else Console.WriteLine("Это не выходной день");
}

checkday(daynum);     