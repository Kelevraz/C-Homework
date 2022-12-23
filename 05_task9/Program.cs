// 9. Напишите программу, которая
// 1. выводит случайное число
// 2. из отрезка [10, 99]
// 3. и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10-99 -> {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

// if(firstDigit > secondDigit) 
// {
//     Console.WriteLine($"Наибольшая цифра полученного числа = {firstDigit}");
// }
// else 
// {
//     Console.WriteLine($"Наибольшая цифра полученного числа = {secondDigit}");
// }

// тернарный оператор
//Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);

// можно также добавить переменную
// 
int result = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.Write($"Наибольшая цифра полученного числа = {result}");
