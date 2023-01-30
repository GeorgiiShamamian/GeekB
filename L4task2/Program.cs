// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int InputInt (string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    return Convert.ToInt32(inputValue);
}

int summation (int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }
    return sum;
}

int number = InputInt ("Введите число");
int result = summation(number);
System.Console.WriteLine($"Сумма цифр в числе равна {result}");