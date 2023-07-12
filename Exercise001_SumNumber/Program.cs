// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void Main()
{
    int numFirst = ReadInt ("Введите первое число: ");
    int numSecond = ReadInt ("Введите второе число: ");
    SumNumbers(numFirst, numSecond);
    Console.WriteLine($"Сумма натуральных элементов равна: {SumNumbers(numFirst, numSecond)}");
}


int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int SumNumbers(int numFirst, int numSecond)
{   
    if (numFirst == 0) 
    {
        return (numSecond * (numSecond + 1)) / 2;
    }
    else if (numSecond == 0) 
    {
        return (numFirst * (numFirst + 1)) / 2;
    }
    else if (numFirst == numSecond) 
    {
        return numFirst;
    }
    else if (numFirst < numSecond) 
    {
        return numSecond + SumNumbers(numFirst, numSecond - 1);
    }
    else return numSecond + SumNumbers(numSecond + 1, numFirst);
}


Main();


