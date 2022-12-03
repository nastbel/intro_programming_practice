Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <1000)
{
    Console.WriteLine(number % 10);
}
else if (number < 100)

{
    Console.WriteLine("Число не имеет третьей цифры");
}
else if (number >= 1000 && number <10000)
{
    Console.WriteLine(number % 100 / 10); 
}

else if (number >= 10000 && number <100000)
{
    Console.WriteLine(number % 1000 / 100); 
}

else {
    Console.WriteLine("число неверное");
};

