// Задача 27: Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("введите число: ");
// int i = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (i > 0)
// {
//     int num = i % 10;
//     i = i / 10;
//     sum = sum + num;
// }
// Console.WriteLine($"сумма всех цифр в числе равна: {sum}");



// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int GetPow(int number, int pow)
// {
//     int result = 1;
//     for (int i = 0; i < pow; i++)
//         result *= number;
//     return result;
// }

// Console.Write("Imput number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Imput pow: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Number square {GetPow(a, b)}");


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//и выводит их на экран.

int[] numbers = new int[8];
Console.Write("Восьмизначный массив [");
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 11);
    Console.Write("" + Method(i) + " ");
}
Console.Write("]");
int Method(int a)
{
    return numbers[a];
}
