// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] generateArray()
{
    List<int> tempArr = new List<int>();

    Console.WriteLine("Для завершения ввода массива нажмите q. Введите для массива число");
    while (true)
    {
        string value = Console.ReadLine();
        if (value == "q")
        {
            break;
        }
        else {
            tempArr.Add(Convert.ToInt32(value));
        }
    }

    int[] numArray = tempArr.ToArray();
    System.Console.WriteLine("[" + string.Join(", ", numArray) + "]");
    return numArray;
}

int countOfPosNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = generateArray();
Console.WriteLine("Количество положительных чисел: " + countOfPosNum(array));

