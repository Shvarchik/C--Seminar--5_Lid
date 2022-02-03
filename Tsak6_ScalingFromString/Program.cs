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
// из исходной строки создать массив строк "число,число"
string[] CoordinatesString(string str, int n)
{
    string[] coordinates = new string[n];
    int j = 0;
    for (int i = 0; i < str.Length; i++)
    {
        string point = String.Empty;
        while (i < str.Length && str[i] != ' ')
        {
            if (str[i] == '(' || str[i] == ')')
            {
                i++;
                continue;
            }
            point += str[i];
            i++;
        }
        coordinates[j] = point;
        j++;

    }
    return coordinates;
}
// из строки "число,число" получить массив из двух чисел
int[] ParseCoordinates(string str)
{
    int[] point = new int[2];
    int j = 0;
    string tempString = String.Empty;
    for (int i = 0; i <= str.Length; i++)
    {
        while (i < str.Length && str[i] != ',')
        {
            tempString += str[i];
            i++;
        }
        point[j] = int.Parse(tempString);
        j++;
        tempString = String.Empty;
    }
    return point;
}
Console.WriteLine("Введите координаты вершин:");
string spisok = Console.ReadLine() ?? "0";
Console.WriteLine("Введите коэффициент масштабирования:");
int k = int.Parse(Console.ReadLine() ?? "0");
int amountOfPoints = NumberOfPoints(spisok);
string[] coordinateStringArray = CoordinatesString(spisok, amountOfPoints);
Console.WriteLine("Новые координаты:");
for (int i = 0; i < amountOfPoints; i++)
{
    int[] coordinateArray = ParseCoordinates(coordinateStringArray[i]);
    Console.Write($"({coordinateArray[0] * k},{coordinateArray[1] * k}) ");
}
