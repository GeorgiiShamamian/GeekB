// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int InputInt (string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int Rank3(int number)
{
    if (number > 1000)
    {
        while (number > 1000)
        {
            number = number / 10;
        }
    }
    number = number % 10;
    return number;
}

int number = InputInt("Введите число");
if (number < 99)
{
    System.Console.WriteLine("В числе нет третьей цифры");
}
else
{
    int result = Rank3 (number);
    System.Console.WriteLine(result);
}