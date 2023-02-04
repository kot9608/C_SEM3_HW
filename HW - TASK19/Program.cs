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
Console.WriteLine ($"Введеное число {num1} - не является полиндром");