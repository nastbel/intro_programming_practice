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
int CountNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        } 
    }
    return count;
}
int[] arr = PosThreedigitNum(7, 100, 1000); 
int count = CountNum(arr);
System.Console.WriteLine("[" + string.Join(", ", arr) + "]"); 
Console.WriteLine(count);
