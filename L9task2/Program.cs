// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Promt(string msg)
{
    System.Console.WriteLine(msg + " > ");
    return int.Parse(Console.ReadLine());
}

void Shownumbers(int number1, int number2, int sum = 0)
{
    while (number1 <= number2)
    {
        sum += number1;
        number1++;
    }
    System.Console.Write($"{sum} ");
}
int number1 = Promt("Введите число M");
int number2 = Promt("Введите число N");

Shownumbers(number1, number2);