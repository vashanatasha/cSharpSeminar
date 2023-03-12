// Задача 24: Напишите программу, которая принимает на вход 
// число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int Sum(int A)
// {
//     int sum = 0; //дополнительная переменная для накопления суммы
//     for (int i = 1; i <= A; i++) //цикл(идем от 1 потому что нет смысла складывать 0)(i <=А чтобы не потерять последнее число)
//     {
//         sum += i; //sum = sum+i
//     }
//     return sum; //возврат в переменную (строка 7)
// }


// Console.Write("введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int sum = Sum(number); //вызов метода(строка 7)
// Console.WriteLine($"Сумма от 1 до {number} = {sum}"); //$-ссылка с переменным, к которой мы обращаемся



// Задача 26.
// Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе. count(доп переменная) (цикл)

// c помощью числа
// int Num(int number)
// {
//     int count = 0;
//     while(number != 0) //пока number не равен 0 (== проверка на равенство, != проверка на неравенство)
//     {
//         number /= 10;
//         count++; //наращиваем count до тех пор, пока number не станет равным 0
//     }
//     return count;
// }
// Console.Write("Введите число: ");
// int number = (Convert.ToInt32(Console.ReadLine())); //Math.Abs если бы в 34 строке было бы неравенство
// int count = Num(number);//сохраняем count (вызываем функцию)

// Console.WriteLine($"Количество цифр в числе: {count}");

// с помощью строки

// Console.Write("Введите число: ");

// string str = Console.ReadLine();
// if(int.TryParse(str, out int number)) //если true то возвращается число number(новая переменная, конвертация из str)
// {
//     if(number<0) //if(str[0] == '-')
//     {
//         System.Console.WriteLine($"Цифр в нашем числе: {str.Length -1}");
//     }
//     else
//     {
//         Console.WriteLine($"Цифр в нашем числе: {str.Length}");
//     }
// }
// else
// {
//     System.Console.WriteLine($"Ошибка");
// }



// Задача 28: Напишите программу, которая принимает на вход 
//число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// int Mult(int N)
// {
//     int mult = 1;
//     for (int i = 1; i <= N; i++) 
//     {
//         mult *= i; 
//     }
//     return mult; 
// }
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int mult = Mult(number); 
// Console.WriteLine($"Произведение от 1 до {number} = {mult}"); //$-ссылка с переменным, к которой мы обращаемся


// Задача 30: Напишите программу, которая выводит массив 
//из 8 элементов, заполненный нулями и единицами 
//в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] FillArray(int size) //название метода
// {
//     int[] arr = new int [size];
//     Random rnd = new Random(); //помогает нам создать переменную типа Random(это системный класс)
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(0, 2);
//     }
//     return arr;
// }

// System.Console.Write("Введите кол-во элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(size);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");//для того чтобы н е писать в 103стр console...(", ", это разделители)


// void FillArray (int [] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while(index < length)
//     {
//         collection[index] = new Random().Next(0,2);
//     }
// }

// void PrintArray(int [] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}");
//     }
//     Console.WriteLine();
// }
// int [] array = new int [8]; //создали массив из 8 эл-тов

// FillArray(array);
// PrintArray(array);



// HOME WORK

// Задача 25: Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16 (math.pow) один цикл for. вернуть произведение 

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string readInput = System.Console.ReadLine();
//     int result = int.Parse(readInput);
//     return result;
// } // либо методом convert, либо TryParse(проверка число это или нет)
// // if(Try.Parse(readInput) int number), else вы ввели не число

// int Power(int powerBase, int exponent)
// {
//     int power = 1; //дополнительная переменная, которая накапливает рез-т
//     for (int i = 0; i < exponent; i++) //exponent = 5, значит должно произойти 5 итераций цикла
//     {
//         power *= powerBase;
//     }
//     return power; //выводится в вывод
// }

// bool ValidateExponent(int exponent) //проверяем яляется ли наш показатель положительным
// {
//     if (exponent < 0)
//     {
//         System.Console.WriteLine("Показатель должен быть не меньше нуля");
//         return false;
//     }
//     return true; 
// }

// int powerBase = Prompt("Введите основание: "); //изначальное число, которое нужно возвести
// int exponent = Prompt("Введите показатель: "); 
// if (ValidateExponent(exponent))
// {
//     System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
// }
// //вызов метода происходит в выводе.



// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе. 
// 452 -> 11
// 82 -> 10
// 9012 -> 12 
// похожа на задачу 26, не только делить на 10 но и складывать их

// int Sum(int number)
// {
//     int result = 0;
//     while(number > 0) // неизвестно ск-ко итераций будет. цикл происходит пока number == 0
//     {
//         result += number % 10;

//         number /= 10;
//     }
//     return result;
// }
// Console.Write("Введите число: ");
// int number = (Convert.ToInt32(Console.ReadLine()));

// Console.WriteLine($"Сумма цифр в числе {number} = {Sum(number)}");



// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] FillArray(int Length, int minValue, int maxValue) //название метода
// {
//     int[] arr = new int [Length];
//     Random rnd = new Random(); //создали переменную типа Random(это системный класс)
//     for (int i = 0; i < Length; i++)
//     {
//         arr[i] = rnd.Next(minValue, maxValue +1); //заполняется весь массив. чтобы последнее число входило в диапозон +1
//     }
//     return arr; //возвращается в PrintArray
// }

// void PrintArray(int[] array)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < array.Length -1; i++) //-1 чтобы заполнились все элементы без лишнего индекса
//     {
//         System.Console.Write($"{array[i]}, ");//вывод значения массива
//     }
//     System.Console.Write($"{array[array.Length -1]}");//вывод значения массива
//     System.Console.WriteLine("]");
// } //метод ничего не вернул, просто сделал вывод

// System.Console.Write("Длина массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Начальное значение для диапозона случайного числа: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Конечное значение для диапозона случайного числа: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] arr = FillArray(length, min, max);// заполнение массива случайными числами, массив принимает данные переменных
// PrintArray(arr); //вывод самого массива
