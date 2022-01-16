// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
// x = (b2-b1)/(k1-k2)

double GetNumber (string s)
{
    Console.Write ($"{s} = ");
    double k = double.Parse(Console.ReadLine() ?? "0");
  return k;
}

Console.WriteLine ("Введите коэффициенты для уравнения y = k1 * x + b1:");
double k1 = GetNumber ("k1");
double b1 = GetNumber ("b1");
Console.WriteLine ("Введите коэффициенты для уравнения y = k2 * x + b2:");
double k2 = GetNumber ("k2");
double b2 = GetNumber ("b2");
double x = (b2-b1) / (k1-k2);
double y = k1*x + b1;
Console.WriteLine ($"Заданные прямые пересекутся в точке ({x:N3}; {y:N3})");
