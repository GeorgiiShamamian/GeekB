// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int [] CreateArray (string message)
{
    System.Console.WriteLine(message + " > ");
    int sizeArray = Convert.ToInt32(Console.ReadLine());
    int [] array = new int[sizeArray];
    return array;
}

int[] CompletionArray(int [] baseArray, string message)
{
    for (int i = 0; i < baseArray.Length; i++)
    {
        System.Console.WriteLine(message + $" > ");
        baseArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return baseArray;
}

void OutputElements(int[] baseArray)
{
    System.Console.WriteLine("Введенные числа:");
    for (int i = 0; i < baseArray.Length; i++)
    {
        System.Console.WriteLine($"{baseArray[i]}");
    }
}

void CheckPositiveNum (int[] baseArray)
{
    int count = 0;
    for (int i = 0; i < baseArray.Length; i++)
    {
        if (baseArray[i] > 0)
        {
            count++;
        }
    }
    System.Console.WriteLine($"Количество чисел больше нуля > {count}");
}

int[] baseArray = CreateArray ("Введите количество чисел для ввода");
string message = $"Введите число";
CompletionArray(baseArray, message);
OutputElements(baseArray);
CheckNum(baseArray);