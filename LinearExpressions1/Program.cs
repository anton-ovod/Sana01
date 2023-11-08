// See https://aka.ms/new-console-template for more information

double a, b, c, d;

Console.Write("Input value for variable `a`: ");
a = double.Parse(Console.ReadLine());

Console.Write("Input value for variable `b`: ");
b = double.Parse(Console.ReadLine());

Console.Write("Input value for variable `c`: ");
c = double.Parse(Console.ReadLine());

Console.Write("Input value for variable `d`: ");
d = double.Parse(Console.ReadLine());

double x, y, z, r;

x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);

y = (5 * (a + b) * (c - d)) / ((1.0 / 2) * c) + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a));

z = (Math.Pow(Math.Pow(x, 2) - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);

r = (((1.0 / 2) * a + (3.0 / 4) * b - (7.0 / 5)) / (3 * c + 1)) + (1.0 / (a - c));

Console.WriteLine("\nResults: ");
Console.WriteLine("x = " + x);
Console.WriteLine("y = " + y);
Console.WriteLine("z = " + z);
Console.WriteLine("r = " + r);
