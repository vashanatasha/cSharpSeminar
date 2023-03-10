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



// Задача 25: Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16 (math.pow) один цикл for. вернуть произведение 

















// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе. 
// 452 -> 11
// 82 -> 10
// 9012 -> 12 
// похожа на задачу 26, не только делить на 10 но и складывать их























// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// 