// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
System.Console.WriteLine("Введите первое число > ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число > ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
    {
        Console.WriteLine($"Первое число {firstNumber} больше второго числа {secondNumber}");
    }
else
    {
        Console.WriteLine($"Второе число {secondNumber} больше первого числа {firstNumber}");
    }