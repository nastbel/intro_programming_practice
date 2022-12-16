//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


double[] PosThreedigitNum(int size, int range, int countDigits)
{
    double[] tempArr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < tempArr.Length; i++)
    {
        tempArr[i] = Math.Round((rand.NextDouble() * range), countDigits);
    }
    return tempArr;
}



double[] array = PosThreedigitNum(5, 10, 3);
double maxNum = array.Max(), minNum = array.Min(), result = maxNum - minNum;
System.Console.WriteLine("[" + string.Join(", ", array) + "]"); 
System.Console.WriteLine("Максимальное число: " + maxNum);
System.Console.WriteLine("Минимальное число: " + minNum);
System.Console.WriteLine("Разница между максимальным и минимальным вещественным числом: " + result );

