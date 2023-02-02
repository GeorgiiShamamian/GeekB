// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int InputInt (string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    return Convert.ToInt32(inputValue);
}

void CreateRandomArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

void PrintRandomArray (int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i != array.Length-1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

int CountEvenDigitsArray (int [] array)
{
    int count = 0;
    for (int a = 0; a < array.Length; a++)
    {
        if (array[a] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int size = InputInt ("Введите число элементов массива");
int[] array = new int [size];
CreateRandomArray (array);
System.Console.Write("Массив:");
PrintRandomArray (array);
int result = CountEvenDigitsArray (array);
System.Console.WriteLine($"Четных цифр в массиве > {result}");