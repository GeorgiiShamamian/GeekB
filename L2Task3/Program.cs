// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int InputInt (string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}
int daynumber = InputInt("Введите номер дня");
if (daynumber > 0 && daynumber < 8)
{
    if (daynumber > 0 && daynumber < 6)
    {
        System.Console.WriteLine("Это будний день");
    }
    else
        System.Console.WriteLine("Это выходной день");
}
else
{
    System.Console.WriteLine("Такого дня не бывает");
}