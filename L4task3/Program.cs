// Напишите программу, которая задаёт массив из любого числа элементов и выводит их на экран. Сделать через функции

int InputInt (string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    return Convert.ToInt32(inputValue);
}

int length = InputInt("Введите число элементов массива");
int min = InputInt("Введите минимальное число массива");
int max = InputInt("Введите максимальное число массива");

bool NumberCheck (int min, int max, int length)
{
    if (min >= max || length == 0 )
    {
        System.Console.Write("Ошибка ввода, максимальное значение не больше минимального");
        return false;
    }
    return true;
}

int [] SetArray(int length)
{
    int [] tempArr = new int [length];
    for (int i = 0; i < length; i++)
        tempArr[i] = new Random().Next(min, max);
    return tempArr;
}

void WriteArrayToConsole (int[] intArray)
{
    for (int i = 0; i < intArray.Length - 1; i++)
    {
        System.Console.Write(intArray[i]);
        System.Console.Write(" ");
    }
    System.Console.Write(intArray[intArray.Length-1]);
}

if (NumberCheck(min, max, length))
{
    System.Console.Write("Массив: ");
    int[] tempArr = SetArray(length);
    WriteArrayToConsole (tempArr);
}