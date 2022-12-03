Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

string[] days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};


if (number >= 6 && number <= 7) 
{
    Console.WriteLine(days[number-1] + " - выходной");
}
else if (number > 0 && number <=5)
 {
    Console.WriteLine(days[number-1] + " - будний день");
}
else Console.WriteLine(" введите число из диапазона");
