// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int InputInt (string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    return Convert.ToInt32(inputValue);
}

void CreateRandomArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble (new Random().Next(100,1000)) / 100;
    }
}

void PrintRandomArray (double[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]:F1}");
        if (i != array.Length-1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

void Calculation (double [] array)
{
    double min = array[0];
    double max = array[0];
    for (int a = 0; a < array.Length; a++)
    {
        if (array[a] > max)
        {
            max = array[a];
        }
        if (array[a] < min)
        {
            min = array [a];
        }
    }
    System.Console.WriteLine($"Максимальное значение элемента массива = {max:F1}.");
    System.Console.WriteLine($"Минимальное значение элемента массива = {min:F1}.");
    System.Console.WriteLine($"Разница {max} и {min} значений элемента массива = {max-min:F1}.");
}

int size = InputInt ("Введите число элементов массива");
double[] array = new double [size];
CreateRandomArray (array);
System.Console.Write("Массив:");
PrintRandomArray (array);
Calculation (array);