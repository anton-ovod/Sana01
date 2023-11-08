// See https://aka.ms/new-console-template for more information

double m, n, a, b, x;

Console.Write("Input value for variable `m`: ");
m = double.Parse(Console.ReadLine());

Console.Write("Input value for variable `n`: ");
n = double.Parse(Console.ReadLine());

Console.Write("Input value for variable `a`: ");
a = double.Parse(Console.ReadLine());

Console.Write("Input value for variable `b`: ");
b = double.Parse(Console.ReadLine());

Console.Write("Input value for variable `x`: ");
x = double.Parse(Console.ReadLine());

double z1, z2, y;

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);

z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

Console.WriteLine("\nResults: ");
Console.WriteLine("z1 = " + z1);
Console.WriteLine("z2 = " + z2);
Console.WriteLine("y = " + y);
