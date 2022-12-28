// Задача 18: Напишите программу, которая по
// заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int number = Convert.ToInt32(Console.ReadLine());

string answer = Quarter(number);

Console.WriteLine(answer);

string Quarter(int num)
{
    if(num == 1) return "xc > 0, yc > 0";
    if(num == 2) return "xc < 0, yc > 0";
    if(num == 3) return "xc < 0, yc < 0";
    if(num == 4) return "xc > 0, yc < 0";
    return "такой четверти не существует";
}