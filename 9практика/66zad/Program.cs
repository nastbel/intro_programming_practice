Console.Write("введите m: "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите n: "); 
int n = Convert.ToInt32(Console.ReadLine());
int SumRec (int m, int n)
{
	if (n < m) return 0;
	else return n + SumRec(m, n - 1);
}
Console.WriteLine(SumRec(m, n));
