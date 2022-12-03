Console.Write("Введите числo: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.Write("Четное число: ");
    Console.WriteLine(num);
}
else {
    Console.Write("Нечетное число: ");
    Console.WriteLine(num); 
}
