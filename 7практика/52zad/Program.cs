// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[4,5];
Random rand = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = rand.Next(0, 10 );
        System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine();
}

for (int j = 0; j < array.GetLength(1); j++)
{
    float avg = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avg = avg + array[i,j];
    }
    avg = avg / array.GetLength(0);
    System.Console.WriteLine("Среднее арифметическое " + (j + 1) + " столбца: " + avg);
}