// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// решение с помощью метода

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool DivCheck(int number1, int number2)
{
    return number1 % number2 == 0;
}

if (DivCheck(number1, number2))
{
    Console.WriteLine($"{number1}, {number2} -> кратно");
}
else
{
    Console.WriteLine($"{number1}, {number2} -> не кратно, остатокот от деления " + (number1 % number2));
}