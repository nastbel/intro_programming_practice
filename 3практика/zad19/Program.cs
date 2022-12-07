System.Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number <100000)
{
    int num1 = number / 10000;
    int num5 = number % 10; 
    int num2 = number / 1000 % 10;
    int num4 = number % 100 / 10;
    if (num1 == num5 && num2 == num4)
    {
       Console.WriteLine("число палиндромное");
    }
    else Console.WriteLine("число не палиндромное");
}
else Console.WriteLine("введите пятизначное число");
