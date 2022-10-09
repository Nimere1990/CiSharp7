/*
Напишите программу, которая на вход принимает число и возвращает позицию (i, j) 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 20);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}
int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
string Position(int[,] array)
{
    string result = string.Empty;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if (num == array[m, n]) result += $"({m}, {n})";
        }
    }
    if (result == string.Empty) result = "Такого элемента нет";
    return result;
}
Console.WriteLine(Position(array));
