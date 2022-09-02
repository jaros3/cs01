// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//  2, 3, 7 -> 7
//  44 5 78 -> 78
//  22 3 9 -> 22

int numberA = 44;
int numberB = 5;
int numberC = 78;
int maxNumber = 0;

if(numberA > numberB && numberA > numberC)
{
    maxNumber = numberA;    
}
else if(numberB > numberA && numberB > numberC)
{
    maxNumber = numberB;
}
else maxNumber = numberC;

Console.WriteLine(maxNumber);
