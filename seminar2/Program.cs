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
