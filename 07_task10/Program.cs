// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Проверяем числа {number1} и {number2}");

int div = number1 % number2;

if (div == 0)
{
    Console.WriteLine($"Число {number1} кратно числу {number2}");
}

else Console.WriteLine($"Число {number1} не кратно числу {number2}. Остаток от деления - {div}");