// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

//int[] array = new int[new Random().Next(1,100)];
int number = new Random().Next(1, 10000);
// int number = 161;
Console.Write($"Сгенерированное число {number} ");


if (number % 7 == 0 && number % 23 == 0) {
    Console.WriteLine("кратно 7 и 23");
} else {
    Console.WriteLine("некратно 7 и 23");
}