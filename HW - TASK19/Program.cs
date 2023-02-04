// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
if (num1/10000==0 || num1/10000>1)
  {
  Console.WriteLine ("Введено не пятизначное число");
  return;
  }
string num1_text = Convert.ToString(num1);
if (num1_text[0]==num1_text[4] && num1_text[1]==num1_text[3]) 
  {
    Console.WriteLine ($"Введеное число {num1} - полиндром");
    return;
  }
Console.WriteLine ($"Введеное число {num1_text} - не является полиндром");




// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.Clear();
// Console.Write("Введите число: ");
// int num1 = int.Parse(Console.ReadLine());
// if (num1/100==0)
//   {
//   Console.WriteLine ("Третьей цифры нет");
//   return;
//   }
// string num1_text = Convert.ToString(num1);
// char Result=num1_text[2];
// Console.WriteLine (Result);