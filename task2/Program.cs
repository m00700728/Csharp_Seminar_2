// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

int x=0, y=0;
string quarter = ""; 
while (x==0) {
    x = new Random().Next(-10, 11);
}
while (y==0) {
    y = new Random().Next(-10, 11);
}

if (x>0 &y>0) {
    quarter = "I";
} else if (x<0 & y>0) {
    quarter = "II";
} else if (x<0 & y<0) {
    quarter = "III";
} else if (x>0 & y<0) {
    quarter = "IV";
}

Console.WriteLine($"Точка с координатами {x} и {y} находится в {quarter} четверти");