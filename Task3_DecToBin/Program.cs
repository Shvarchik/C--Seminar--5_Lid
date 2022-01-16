// 43. Преобразование десятичного числа в двоичное

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]);
    Console.WriteLine();
}

Console.Write("Введите число:");
int N = int.Parse(Console.ReadLine() ?? "0");
int Y = 0;
int len = 0;
while (N >= Math.Pow(2, Y))
{
    len = Y;
    Y++;
}
len++;
// если цикл пройден хотя бы один раз, len будет совпадать с Y, если ни разу (для N=O), то len=1
//В двоичном представлении числа N будет len позиций")

int[] BinArray = new int[len];
int Div = N;
for (int i = len - 1; i >= 0; i--)
{
    BinArray[i] = Div % 2;
    Div = Div / 2;
}
Console.Write($"Двоичное представление числа {N}: ");
PrintArray(BinArray);
