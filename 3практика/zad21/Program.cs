int[] point = new int[3];
System.Console.WriteLine("Введите координату А1: "); // x1
point[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату А2: "); // y1
point[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату А3: "); // z1
point[2] = Convert.ToInt32(Console.ReadLine());

int[] point2 = new int[3];
System.Console.WriteLine("Введите координату B1: ");
point2[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату B2: ");
point2[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату B3: ");
point2[2] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Math.Sqrt(Math.Pow(point2[0] - point[0], 2) + Math.Pow(point2[1] - point[1] , 2) + Math.Pow (point2[2] - point[2], 2)));

