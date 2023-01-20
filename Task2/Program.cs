// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
System.Console.WriteLine("Введите первое число > ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число > ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число > ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
    if (firstNumber > thirdNumber)
        {
            Console.WriteLine($"Первое число {firstNumber} - максимальное");
        }
    else 
        {
            Console.WriteLine($"Третье число {thirdNumber} - максимальное");
        }
if (secondNumber > firstNumber)
    if (secondNumber > thirdNumber)
        {
            Console.WriteLine($"Первое число {secondNumber} - максимальное");
        }
    else 
        {
            Console.WriteLine($"Третье число {thirdNumber} - максимальное");
        }