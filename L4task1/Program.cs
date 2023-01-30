// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int InputInt (string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    return Convert.ToInt32(inputValue);
}

bool NumberCheck (int numberB)
{
    if (numberB < 0)
    {
        System.Console.WriteLine("Показатель должен быть не отрицательным");
        return false;
    }
    return true;
}

long Pow (int numberA, int numberB)
{
    int degree = 1;
    long result = 1;
    while (degree <= Math.Abs(numberB))
    {
        result *= numberA;
        degree++;
    }
    return result;
}
int numberA = InputInt("Введите основание");
int numberB = InputInt("Введите показатель");
if (NumberCheck(numberB))
{
    long result = Pow (numberA, numberB);
    System.Console.WriteLine($"Число {numberA} в степени {numberB} равно {result}");
}