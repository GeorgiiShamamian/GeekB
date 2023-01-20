// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
System.Console.WriteLine("Введите число > ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
    {
        number = -1*number;
    }

else 
    {
        number = number;
    }

int result = number % 2;

if (result > 0)
    {
        Console.WriteLine($"Число нечетное");
    }

else 
    {
        Console.WriteLine($"Число четное");
    }