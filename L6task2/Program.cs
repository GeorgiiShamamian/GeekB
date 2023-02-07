// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

const int K1 = 0;
const int B1 = 1;
const int K2 = 2;
const int B2 = 3;

void InputData(double[] parametr, string message)
{
    System.Console.WriteLine("Введите параметр K1 > ");
    System.Console.WriteLine("Введите параметр B1 > ");
    System.Console.WriteLine("Введите параметр K2 > ");
    System.Console.WriteLine("Введите параметр B2 > ");
    for (int i = 0; i <= parametr.Length - 1; i++)
    {
        parametr[i] = Convert.ToDouble(Console.ReadLine());
    }
}

double FindX (double[] parametr)
{
    double x = (parametr[B2] - parametr[B1]) / (parametr[K1] - parametr[K2]);
    return x;
}

double FindY (double[] parametr)
{
    double x = FindX(parametr);
    double y = parametr[K1] * x + parametr[B1];
    return y;
}

double[] parametr = new double[4];
InputData (parametr, "Введите расчетные параметры");
double resultX = FindX(parametr);
double resultY = FindY(parametr);
System.Console.WriteLine($"Координаты пересечения двух прямых будут в точке > {resultX:F1}, {resultY:F1}");