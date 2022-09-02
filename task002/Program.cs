// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int numberA = 2;
int numberB = 10;
int maxNumber = 0;
int minNumber = 0;

if(numberA > numberB)
{
    maxNumber = numberA;
    minNumber = numberB;
}
else
{
    maxNumber = numberB;
    minNumber = numberA;
}

Console.Write("Максимальное число - ");
Console.WriteLine(maxNumber);
Console.Write("Минимальное число - ");
Console.WriteLine(minNumber);

