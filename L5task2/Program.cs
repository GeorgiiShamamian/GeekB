// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
        array[i] = new Random().Next(1,10);
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

int SummOfOddElements (int [] array)
{
    int sum = 0;
    for (int a = 0; a < array.Length; a += 2)
    {
        sum = sum + array [a];
    }
    return sum;
}

int size = InputInt ("Введите число элементов массива");
int[] array = new int [size];
CreateRandomArray (array);
System.Console.Write("Массив:");
PrintRandomArray (array);
int result = SummOfOddElements (array);
System.Console.WriteLine($"Сумма элементов на нечентных позициях > {result}");