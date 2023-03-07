// Задача №17. Напишите программу, которая принимает на вход 
//координаты точки (X и Y), причем X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.Write("Введите координату Y ");
// int Y = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату X ");
// int X = Convert.ToInt32(Console.ReadLine());

// if (X > 0 && Y > 0)
// {
//     Console.Write("Точка лежит в первой четверти");
// }
// else if (X < 0 && Y > 0)
// {
//     Console.Write("Точка лежит во второй четверти");
// }
// else if (X < 0 && Y < 0)
// {
//     Console.Write("Точка лежит в третьей четверти");
// }
// else if (X > 0 && Y <0)
// {
//     Console.Write("Точка лежит в четвертой четветри");
// }
// else
// {
//     Console.Write("Точка лежит на оси");
// }




// Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).

// Console.Write("Введите номер четверти ");
// int quarter = Convert.ToInt32(Console.ReadLine());

// if (quarter == 1)
// {
//     Console.Write("x > 0 && y > 0");
// }
// else if (quarter == 2)
// {
//     Console.Write("X < 0 && Y > 0");
// }
// else if (quarter == 3)
// {
//     Console.Write("X < 0 && Y < 0");
// }
// else if (quarter == 4)
// {
//     Console.Write("X > 0 && Y <0");
// }
// else
// { 
//     Console.Write("Повторите ввод четверти");
// }

//Решение задачи с помощью массива
// string[] quaters = {"x > 0; y > 0",
//                     "x < 0; y > 0",
//                     "x < 0; y < 0",
//                     "x > 0; y < 0"};
// System.Console.Write("Введите номер четверти: ");
// int quater = Convert.ToInt32(Console.ReadLine());

// if (quater >= 1 && quater <=4)
// {
//     System.Console.WriteLine(quaters[quater -1]);
// }
// else
// {
//     System.Console.WriteLine("Неправильный номер четверти");
// }



// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними 
// в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// формула нахождения расстояния
// d = √ [(x2-x1)2+ (y2-y1)2 ]
/*
double Distance2D(double x1, double y1, double x2, double y2)
{
    double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return Math.Round(res, 2);
}

Console.Write("Введите первую точку оси X ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите вторую точку оси X ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите первую точку оси Y ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите вторую точку оси Y ");
double y2 = Convert.ToDouble(Console.ReadLine());

double distance = Distance2D(x1, y1, x2, y2);
System.Console.WriteLine($"Расстояние между точками = {distance}");
*/



//Напишите программу, которая принимает на вход число (N) 
// и выдает таблицу квадратов чисел от 1 до N

/*
Console.Write("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());

for(int i = 1; i <= number; i++)
{
    Console.Write($"{Math.Pow(i, 2)} ");
}
*/