//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNum(int num)
{
    int[] digits = num.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();
    int counter = digits.Length;
    int sum = 0;
    for (int i = 0; i < counter; i++)
    {
        int digit = digits[i] - 48;
        sum = sum + digit;
    }
    return sum;
}

Console.WriteLine(SumNum(num));
