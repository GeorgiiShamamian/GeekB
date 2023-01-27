// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int InputInt (string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int number = InputInt("Введите число");
System.Console.WriteLine("Куб числа");
for (int index = 1; index <= number; index++)
{
    int result = index * index * index;
    System.Console.WriteLine($"{result}");
}