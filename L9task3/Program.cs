// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Promt(string msg)
{
    System.Console.WriteLine(msg + " > ");
    return int.Parse(Console.ReadLine());
}

int Akkerman(int number1, int number2)
{
    if (number1 == 0)
    {
        return number2 + 1;
    }
    else 
        if (number2 == 0 && number1 > 0)
        {
            return Akkerman(number1 - 1, 1);
        }
        else
            {
            return Akkerman(number1 - 1, Akkerman(number1, number2 - 1));
            }
}

int number1 = Promt("Введите число M");
int number2 = Promt("Введите число N");
int akkermanFunction = Akkerman(number1, number2);
Console.Write($"Число M = {number1}, число N = {number2} - > A(M,N) = {akkermanFunction}");