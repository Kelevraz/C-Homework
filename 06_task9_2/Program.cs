// 9. Напишите программу, которая
// 1. выводит случайное число
// 2. из отрезка [10, 99]
// 3. и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// решение методом

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10-99 -> {number}");

int maxDigit = MaxDigit(number);
Console.Write($"Наибольшая цифра полученного числа = {maxDigit}");

int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}
// либо так
// return firstDigit > secondDigit ? firstDigit : secondDigit;