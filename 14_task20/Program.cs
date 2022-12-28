// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите координату x точки 1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y точки 1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату x точки 2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y точки 2");
// int y2 = Convert.ToInt32(Console.ReadLine());

// int InsertPosition(string text)
// {
//     Console.WriteLine(text);
//     int pos = Convert.ToInt32(Console.ReadLine());
//     return pos;
// }

// int x1 = InsertPosition("Введите координату x точки 1");
// int y1 = InsertPosition("Введите координату y точки 1");
// int x2 = InsertPosition("Введите координату x точки 2");
// int y2 = InsertPosition("Введите координату y точки 2");

// double LenghtLine (int x1, int x2, int y1, int y2);
// {
//     int temp = (xpos1 - xpos2) * (xpos1 - xpos2)
//     + (ypos1 - ypos2) * (ypos1 - ypos2);
//     return Math.Sqrt(temp);
// }

// double result = LenghtLine(x1, x2, y1, y2);

// double resRound = Math.Round(result, 2, MidpointRounding.ToZero);

// Console.WriteLine($"Расстояние между точками равно: {resRound}");

// int temp = (xpos1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);



int InsertPositon(string text)
{
    Console.WriteLine(text);
    int pos = Convert.ToInt32(Console.ReadLine());
    return pos;
}

int x1 = InsertPositon("Введите координату Х первой точки:");
int y1 = InsertPositon("Введите координату Y первой точки:");

int x2 = InsertPositon("Введите координату Х второй точки:");
int y2 = InsertPositon("Введите координату Y второй точки:");

double LenghtLine(int xpos1, int xpos2, int ypos1, int ypos2)
{
    int temp = (xpos1 - xpos2) * (xpos1 - xpos2) + (ypos1 - ypos2) * (ypos1 - ypos2);
    return Math.Sqrt(temp);
}

double res = LenghtLine(x1, x2, y1, y2);

double resRound = Math.Round(res, 2, MidpointRounding.ToZero);

Console.WriteLine($"Растояние между точками равно : {resRound}");

