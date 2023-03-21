//Задача 31. Задайте массив из 12 элементов,
//заполненный случайными числами из промежутка [-9,9]
//Найдите сумму отрицательных и положительных эл. массива.

// int [] FillArrayWhithRandomNumber (int size)
// {
//     int[] arr = new int [size];
//     Random rnd = new Random();
//     for(int i = 0; i < arr.Length; i ++)
//     {
//         arr[i] = rnd.Next(-9, 10);
//     }
//     return arr;
// }

// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = FillArrayWhithRandomNumber(size);


// int sumPositive = 0;
// int sumNegative = 0;
// for(int i = 0; i < array.Length; i ++)
// {
//     if (array[i] > 0)
//     {
//         sumPositive += array[i];
//     }
//     else
//     {
//         sumNegative += array[i];
//     }
// }

// System.Console.Write("Ваш случайный массив: ");
// System.Console.WriteLine($"[{string.Join(", ", array)}]");
// System.Console.WriteLine($"Сумма положительных значений равна {sumPositive}, а сумма отрицательных равна {sumNegative}");


// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// один массив или неск.

// int [] FillArrayWhithRandomNumber (int size)
// {
//     int[] arr = new int [size];
//     Random rnd = new Random();
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(-9, 10);
//     }
//     return arr;
// }

// int [] ChangeArray(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] *= -1;
//     }
//     return arr;
// }

// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = FillArrayWhithRandomNumber(size);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");
// int [] changeArray = ChangeArray(array);
// System.Console.WriteLine($"[{string.Join(", ", changeArray)}]");


// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

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

// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWhithRandomNumber(size);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");

// System.Console.WriteLine("Введите число: ");
// int search = Convert.ToInt32(Console.ReadLine());

// bool isOk = false;
// for(int i = 0; i < array.Length; i++)
// {
//     if(search == array[i])
//         {
//         isOk = true;
//         break;
//         }
// }
// if(isOk)
// {
//     System.Console.WriteLine("Элемент найден");
// }
// else
// {
//     System.Console.WriteLine("Элемент не найден");
// }

// Второй вариант решения
// string result = "No";

// for(int i=0; i<array.Length; i++)
// {
// if(array[i] == search)
// {
// result = "yes";
// break;
// }
// }
// System.Console.WriteLine(result);



// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// проходимся по массиву. с помощью if. count ++. выводим count 

// int[] FillArrayWhithRandomNumber(int size)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for(int i = 0; i < arr.Length; i++)
//         {
//         arr[i] = rnd.Next(0, 150);
//         }
//     return arr;
// }

// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWhithRandomNumber(size);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");

// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array [i] >= 10 && array[i] <= 99)
//     {
//         count++;
//     }
// }
// System.Console.WriteLine(count);



// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй 
// и предпоследний и т.д. Результат запишите в новом массиве.
// if четность на четность. 

// int[] FillArrayWhithRandomNumber(int size)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for(int i = 0; i < arr.Length; i++)
//         {
//         arr[i] = rnd.Next(0, 150);
//         }
//     return arr;
// }

// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWhithRandomNumber(size);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");

// int newLength = array.Length / 2 + array.Length % 2;
// int[] newArray = new int[newLength];
// for(int i = 0; i < array.Length / 2; i++)
// {
//     newArray[i] = array[i] * array[array.Length - 1 - i];
// }
// if(array.Length % 2 > 0)
// {
//     newArray[newArray.Length - 1] = array[array.Length / 2];
// }
// System.Console.WriteLine($"[{string.Join(", ", array)}]");
// System.Console.WriteLine($"[{string.Join(", ", newArray)}]");


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
//  числами. Напишите программу, которая покажет количество нечётных чисел в массиве.

// int[] FillArrayWhithRandomNumber(int size)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for(int i = 0; i < arr.Length; i++)
//         {
//         arr[i] = rnd.Next(100, 1000);
//         }
//     return arr;
// }

// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWhithRandomNumber(size);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");

// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         count++;
//     }
// }
// System.Console.WriteLine(count);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// нечетный индекс. можно решить как 34. вместо count сумма и 
// проверка на нечетность или указать шаг

// int[] FillArrayWhithRandomNumber(int size)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for(int i = 0; i < arr.Length; i++)
//         {
//         arr[i] = rnd.Next(0, 100);
//         }
//     return arr;
// }

// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWhithRandomNumber(size);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");
    
// int Sum (int [] array)
// {
//     int sum = 0;
//     int i = 0;
//     while (i < array.Length)
//     {
//         sum = sum + array[i];
//         i += 2;
//     }
//     return sum;
// }
// Console.WriteLine($"Сумма равна {Sum(array)}");



// Задача 38: Задайте массив вещественных чисел(тип double). 
// Найдите разницу между максимальным и минимальным элементов массива.
// рандом некст дабл. исользовать округление

Console.Write("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.Write("массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}