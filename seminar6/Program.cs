// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int[] FillArrayWhithRandomNumber(int size)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for(int i = 0; i < arr.Length; i++)
//         {
//         arr[i] = rnd.Next(-9, 10);
//         }
//     return arr;
// }

// void ReverseArray (int [] arr)
// {
//     int temp = 0;
//     for(int i = 0; i < arr.Length/2; i++)
//     {
//         temp = arr[i]; 
//         arr[i] = arr[arr.Length - 1 - i]; //первый элемент записываем в последний
//         arr[arr.Length - 1 - i] = temp;
//     }
// }


// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWhithRandomNumber(size);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");
// ReverseArray(array);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");


// Задача 40 Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// if

Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double num3 = Convert.ToDouble(Console.ReadLine());

if (num1 + num2 > num3 && num1 +num3 > num2 && num3 + num1 > num2)
{
    Console.Write("Треугольник возможен:)");
}
else
{
    Console.Write("Треугольник не получился:()");
}



// Задача 42: Напишите программу, которая будет преобразовывать десятичное число 
// в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int [] ConDecToBin(int num)
{

}