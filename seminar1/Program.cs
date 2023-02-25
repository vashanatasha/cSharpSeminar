// Напишите программу, которая на вход принимает два числа и 
//проверяет, является ли первое число квадратом второго.
/*
Console.Write("input a first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int quad2 = number2 * number2;

if(number1 == quad2)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}
*/


// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Input a positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/


// Задача 2. Напишите программу, которая на вход принимает два числа и 
//выдает, какое число большее, а какое меньшее.
/*
Console.Write("input a first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
int min = number2;
if(max > number2)
{
    max = number1;
    min = number2;
}
else 
{
    max = number2;
    min = number1;
}
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);
*/

// Задача 4. Напишите программу, которая принимает 
//на вход три числа и выдает максимальное из этих чисел.
/*
Console.Write("input a first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input the third number ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
if (num1 > max) max = num1;
Console.Write("max = ");
Console.WriteLine(max);
*/

// Задача 6. Напишите программу, которая на вход принимает число и выдает,
// является ли число четным
/*
Console.Write("input a number ");
int num = Convert.ToInt32(Console.ReadLine());
int current = (num % 2);
if(current ==0)
{
    Console.WriteLine("Yeap!");
}
else 
{
    Console.WriteLine("No");
}
*/