﻿//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

int InputNumber(string str)
{
    int number;
    string text;

    while(true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать текст");
    }
    return number;
}

Console.Clear();
System.Console.WriteLine("Введите размер массива M x N");
int m = InputNumber("Введите M: ");
int n = InputNumber("Введите N: ");
int[,] array = new int[m,n];
Random rand = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = rand.Next(-10, 10 );
        System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine();
}


