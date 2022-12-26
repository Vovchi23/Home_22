// Напишите программу, которая принимает на вход трёхзначное число
// на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.Write("Введите трех значное число ");

int number = int.Parse(Console.ReadLine()!);
 if (number <0)
 {
    number = number*(-1);
 }
 Console.WriteLine(number);
int digi = number/10;
Console.WriteLine(digi%10);
