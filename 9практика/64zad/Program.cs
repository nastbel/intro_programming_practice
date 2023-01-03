Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
string NumRec(int n)
{
	if (1 <= n) return $"{n} " + NumRec(n - 1);
    else return String.Empty;
}

Console.WriteLine(NumRec(n));