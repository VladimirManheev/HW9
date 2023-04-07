// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int numberM = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());


void OutPutNumber (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма чисел: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    OutPutNumber(numberM, numberN, sum);
}

OutPutNumber(numberM, numberN, 0);
