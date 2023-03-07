/*
//Напишите программу, которая выводит случайное трёхзначное 
//число и удаляет вторую цифру этого числа.

int CutNumber(int num)
{
    int hundreds = num / 100;
    int ones = num % 10;
    
    return hundreds * 10 + ones;
}

int randNumber = new Random().Next(100, 1000);

int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/



//Напишите программу, которая принимает на вход число 
//и проверяет, кратно ли оно одновременно a и b.
/*
bool IsDivided(int number, int firstDivider, int secondDivider)
{
    return number % firstDivider == 0 && number % secondDivider == 0;

    // if(number % firstDivider == 0 && number % secondDivider == 0)
    //     return true;
    // else
    //     return false;
}

Console.Write("Input a number for checking: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first divider: ");
int div1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second divider: ");
int div2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsDivided(num, div1, div2));
*/


// Напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.

/*
int num = new Random().Next(10, 100);
int MaxNumber (int num)
{
    int ten = num / 10;
    int one = num % 10;
    if(ten>one)
        return ten;
    else
        return one;
}
Console.WriteLine($"Рандомное число это: {num} наибольшая цифра это: {MaxNumber(num)}");
*/



// Напишите программу, которая принимает на вход два числа и 
//проверяет, является ли одно число квадратом другого.
/*
bool IsQuad (int firstNum, int secondNum)
{
    if (firstNum == secondNum*secondNum || secondNum == firstNum*firstNum)
        return true;
        else return false;
}
Console.Write("Input a number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsQuad (num1, num2));
*/


// Напишите программу, которая принимает на вход трехзначное 
//число и на выходе показывает вторую цифру этого числа

// int Prompt (string message)
// { //метод
//     System.Console.Write(message); //выводится строка "введите трхзн число"
//     string value = Console.ReadLine(); //новая переменная под ввод
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int number = Prompt("Введите трехзначное число > "); //делаем вызов и в скобках передаем значение, которое просится в 85 строчке
// if (number < 100 || number >= 1000)
// {
//     Console.WriteLine("Вы ввели не трехзначное число, повторите ввод");
//     return;
// }
// Console.WriteLine($"Введенное число {number}");
// int secondRank = number / 10 % 10;
// Console.WriteLine($"Вторая цифра {secondRank}");


// Задача 10. Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.


// int Prompt(string message)
// {
//     Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int ThirdRank (int num)
// {
//     while (num > 999)
//     {
//         num /= 10;    //num = num/10
//     }
//     return num % 10;
// }

// bool ValidateNum (int num)
// {
//     if (num < 100)
//     {
//         Console.WriteLine("третьего числа нет");
//         return false;
//     }
//     return true;
// }


// int num = Prompt("введите число ");
// if (ValidateNum(num)) //валидатор подразумевает тру или фолс
// {
//     Console.WriteLine(ThirdRank(num));
// }
