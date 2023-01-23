// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int InputInt (string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

bool Validate (int number)
{
    if (number > 99 && number < 1000)
    {
        return true;
    }
    System.Console.WriteLine("Число не трехзначное");
    return false;
}

int number = InputInt("Введите трехзначное число");
if (Validate(number))
{
    number = number / 10;
    number = number % 10;
    System.Console.WriteLine($"Вторая цифра введенного числа это {number}");
}
