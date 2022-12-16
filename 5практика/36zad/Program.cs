//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int[] PosThreedigitNum(int size, int leftRange, int rightRange)
{
    int[] tempArr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < tempArr.Length; i++)
    {
        tempArr[i] = rand.Next(leftRange, rightRange);
    }
    return tempArr;
}

int Sum(int[] arr) {
    int sumOdd = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) {
            sumOdd = sumOdd + arr[i];
        }
    }
    return sumOdd;
}

int[] array = PosThreedigitNum(4, -100, 100); 
int sumOdd = Sum(array);
System.Console.WriteLine("[" + string.Join(", ", array) + "]"); 
System.Console.WriteLine($"Сумма нечетных элементов массива: {sumOdd}");