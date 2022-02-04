// 46. Написать программу масштабирования фигуры
// вершины фигуры задаются списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

using System.Linq;
// Подсчет вершин фигуры по числу запятых в строке
int NumberOfPoints(string str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
        if (str[i] == ',')
            count++;
    return count;
}
// из исходной строки создать массив чисел
int[] ParseCoordinates(string str, int n)
{
    int[] coordinates = new int[n*2];
    int j = 0;
    string point = String.Empty;
    for (int i = 0; i < str.Length; i++)
    {
        while (i < str.Length && (str[i]!='(' && str[i]!=','))
        {
            i++;
        }
        i++;
        if (i < str.Length)
        {
            while (str[i]!=',' && str[i] !=')')
            {
                point += str[i];
                i++;
            }            
            coordinates[j] = int.Parse(point);
            j++;
            point = String.Empty;
            i--;           
        }
    }
    return coordinates;
}

Console.WriteLine("Введите координаты вершин:");
string spisok = Console.ReadLine() ?? "0";
Console.WriteLine("Введите коэффициент масштабирования:");
int k = int.Parse(Console.ReadLine() ?? "0");
int amountOfPoints = NumberOfPoints(spisok);
int[] coordinateArray = ParseCoordinates(spisok, amountOfPoints);
Console.WriteLine("Новые координаты:");
for (int i = 0; i < amountOfPoints*2; i+=2)
     Console.Write($"({coordinateArray[i] * k},{coordinateArray[i+1] * k}) ");

