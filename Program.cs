// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Clear();
Console.WriteLine("Введи любое число: ");
int num=int.Parse(Console.ReadLine()!);
int num1=num%100;
int num2=num/10;
int num3=num/100;
if(num>=100)
{
    Console.Write($"Число {num}->{num3}");
}
else
{
    Console.Write("Третьей цифры нет");
}
