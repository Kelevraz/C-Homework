// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Console.WriteLine("Enter the number");
// int number = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Ostatok " + number%10);
// or
// Console.WriteLine($"Последняя цифра числа {num}: {num % 10}");

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(num % 10);
if (num >= 100 && num <= 999) // проверка на трехзначность
{
    Console.WriteLine($"Последняя цифра числа {num}: {num2}");
}
else
{
    Console.WriteLine("Число не трехзначное!");
}