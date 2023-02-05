// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int max = Convert.ToInt32(Console.ReadLine());

if (min <= 0 || max <= 0)
{
    Console.Write("Введено число меньше или равное нулю");
}
else if (min > max)
{
    int temp = min;
    min = max;
    max = temp;
    
    int sumM = NaturalNumbersSum(min, max);
    Console.Write(sumM);
}
else
{
    int sumM = NaturalNumbersSum(min, max);
    Console.Write(sumM);
}

int NaturalNumbersSum(int minNum, int maxNum) //int sum=0
{
    if (minNum == maxNum) return minNum;
    else return minNum + NaturalNumbersSum(minNum + 1, maxNum);
}
