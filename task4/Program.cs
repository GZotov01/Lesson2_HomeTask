﻿// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
// не используя строки, но в обратном порядке

int N = 12345;

int r = 5; // Введите количество цифр в числе N

int i = 1;
int sum = N;
if (N >= 1)
{
    while (i <= r)
    {
        if (i == r)
        {
            sum = N % 10;
            Console.Write(sum);
            break;
        }
        else{
        sum = N % 10;
        Console.Write($"{sum},");
        N = N / 10;
        i += 1;
        }
    }
}
else
{
    Console.WriteLine($"Число {N} не является натуральным");
}
