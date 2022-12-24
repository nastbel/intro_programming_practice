//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
//строки двумерного массива.
//Например, задан массив: 
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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
        array[i,j] = rand.Next(0, 9);
        System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine();
}


OrderArrayLines(array);
WriteArray(array);

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
  System.Console.WriteLine("Отсортированный массив: ");
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}