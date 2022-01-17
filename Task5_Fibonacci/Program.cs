// 45 Показать числа Фибоначчи

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine($"f ({i}) = {array[i]}");
}
Console.WriteLine ("Введите число для последовательности Фибоначчи:");
int N = int.Parse(Console.ReadLine() ?? "0");
double [] f = new double [N+1];
f[0] = 0;
f[1] = 1;
for (int i=2;i < f.Length;i++)
    f[i] = f[i-1] + f [i-2];

PrintArray(f);

    

