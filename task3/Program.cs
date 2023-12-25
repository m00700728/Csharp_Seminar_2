// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.


int number = new Random().Next(10, 100);

string d1 = Convert.ToString(number);
char s1 = d1[0];
char s2 = d1[1];
string compare = "";

if (Convert.ToInt32(s1) > Convert.ToInt32(s2)) {
    compare = "больше";
} else if (Convert.ToInt32(s1) < Convert.ToInt32(s2)) {
    compare = "меньше";
} else if (Convert.ToInt32(s1) == Convert.ToInt32(s2)) {
    compare = "равно(а)";
}

Console.WriteLine($"В числе {number} цифра {s1} {compare} {s2}");

