//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
//элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет


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
        System.Console.Write("Не удалось распознать текст");
    }
    return number;
}
int m = InputNumber("Введите позицию в строке: ");
int n = InputNumber("Введите позицию в столбце: ");
Console.Clear();
int[,] array3 = { { 1, 4, 7, 2}, { 5, 9, 2, 3}, { 8, 4, 2, 4 } };

if (m < array3.GetLength(0) && n < array3.GetLength(1))
{
    System.Console.WriteLine(array3[m,n]);
}
else 
{
    System.Console.WriteLine("Нет такого  элемента");
}