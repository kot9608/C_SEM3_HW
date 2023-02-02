//Задача №18. Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти: ");
int chetvert = int.Parse(Console.ReadLine());

if(chetvert==1)
{
    Console.WriteLine("X>0, Y >0");
}
if(chetvert==2)
{
    Console.WriteLine("X<0 , Y>0");
}
if(chetvert==3)
{
    Console.WriteLine("X<0, Y<0");
}
if(chetvert==4)
{
    Console.WriteLine("X>0, Y<0");
}