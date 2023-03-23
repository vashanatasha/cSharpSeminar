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

// Console.Write("Введите первое число: ");
// double num1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите второе число: ");
// double num2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите третье число: ");
// double num3 = Convert.ToDouble(Console.ReadLine());

// if (num1 + num2 > num3 && num1 +num3 > num2 && num3 + num1 > num2)
// {
//     Console.Write("Треугольник возможен:)");
// }
// else
// {
//     Console.Write("Треугольник не получился:()");
// }



// Задача 42: Напишите программу, которая будет преобразовывать десятичное число 
// в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int [] ConDecToBin(int num)
// {

// }









// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// void PrintFibToN(int N)
// {
//     int fib1 = 0;
//     int fib2 = 1;
//     int fib3 = 0;
//     Console.Write("0 1 ");
//     for (int i = 0; i < N - 2; i++)
//     {
//         fib3 = fib1 + fib2;
//         Console.Write($"{fib3} ");
//         fib1 = fib2;
//         fib2= fib3;
//     }
// }
// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// PrintFibToN(num);


// массив
// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int [] array = new int [num];
// array[0] = 0;
// array[1] = 1;
// for (int i = 2; i < num; i++)
// {
//     array[i] = array[i -2] + array[i -1];
// }
// System.Console.Write("Array: ");
// Console.WriteLine($"[{string.Join(", ", array)}]");



// Задача 45: Напишите программу, которая будет создавать копию заданного 
// массива с помощью поэлементного копирования.
// int[] FillArrayWhithRandomNumber(int size)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(-9, 10);
//     }
//     return arr;
// }

// int[] CopyArray(int[] arr, int size)
// {
//     int[] copyArr = new int[size];
//     for(int i = 0; i < copyArr.Length; i++)
//     {
//         copyArr[i] = arr[i]; //из старого массива записываем в copy массив 
//     }
//     return copyArr;
// }

// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWhithRandomNumber(size);

// int[] changeArray = CopyArray(array, size);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");
// System.Console.WriteLine($"[{string.Join(", ", changeArray)}]");





// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int [] InputArray(int length)

// {
//     int [] array = new int [length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Prompt($"Введите {i + 1}-й элемент ");
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i <array.Length; i++)
//     {
//         System.Console.WriteLine($"a[{i}] = {array[i]}");
//     }
// }

// int PositiveNumbers(int [] array)
// {
// int count = 0;
// for (int i = 0; i < array.Length; i++)
//     {
//     if (array[i] > 0)
//         {
//             count++;
//         }
//     }   
//     return count;
// }
// int length = Prompt("Введите количество элементов ");
// int [] array;
// array = InputArray(length);
// PrintArray(array);
// System.Console.WriteLine($"Количество чисел больше 0 - {PositiveNumbers(array)}");
