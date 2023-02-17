// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

int Promt(string msg)
{
    System.Console.WriteLine(msg + " > ");
    return int.Parse(Console.ReadLine());
}

void Shownumbers(int number1, int number2)
{
    if (number1 % 2 == 0)
    {
        if (number1 > number2)
        {
            return;
        }
        System.Console.Write($"{number1} ");
        Shownumbers(number1 + 2, number2);
    }
    else 
    {
        number1 += 1;
        System.Console.Write($"{number1} ");
        Shownumbers(number1 + 2, number2);
    }
}

int number1 = Promt("Введите число M");
int number2 = Promt("Введите число N");

Shownumbers(number1, number2);