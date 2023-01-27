// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не используйте строки
int InputNumber (string message)
{
    System.Console.Write(message + " > ");
    string? number = Console.ReadLine();
    if (int.TryParse(number, out int variable)) 
    {
        return variable;
    }
    System.Console.WriteLine("Это не число");
    return 0;
}

int ReverseNumber (int number)
{
    int temp = 0;
    int reverse = 0;
    temp = number;
    while (temp > 0)
    {
        reverse = reverse * 10;
        reverse = reverse + temp % 10;
        temp = temp / 10;
    }
    return reverse;
}
bool Palindrom (int number)
{
    int reverse = ReverseNumber(number);
    return number == reverse;
}     

int number = InputNumber("Введите любое число");
if (number == 0)
{
    System.Console.WriteLine("Введенное значение не соответствует условию");
}
else
{
    if (Palindrom(number))
    {
        System.Console.WriteLine ($"Введенное число {number} - палиндром");
    }
        else
    {
        System.Console.WriteLine ($"Введенное число {number} - не палиндром");
    }
}