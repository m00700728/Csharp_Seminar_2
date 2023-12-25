// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

int number = new Random().Next(1, 100000);
string str = Convert.ToString(number);
int len = str.Length;
char c;

Console.Write($"Натуральное число {number} длиной {len} состоит из цифр: ");

for (int i = 0; i < len - 1; i++) {
    c = str[i];
    Console.Write($"{c},");
}
c = str[len-1];
Console.Write($"{c}");
