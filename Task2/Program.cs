// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int Coordinate (string CoordinateName, string PointName)
{
    System.Console.WriteLine($"Введите координату {CoordinateName} точки {PointName}");
    return Convert.ToInt32(Console.ReadLine());
}

int X1 = Coordinate("X", "A");
int Y1 = Coordinate("Y", "A");
int Z1 = Coordinate("Z", "A");
int X2 = Coordinate("X", "B");
int Y2 = Coordinate("Y", "B");
int Z2 = Coordinate("Z", "B");

double Calculate (double X1, double X2, double Y1, double Y2, double Z1, double Z2)
{
    double move1 = Math.Pow(X2-X1, 2);
    double move2 = Math.Pow(Y2-Y1, 2);
    double move3 = Math.Pow(Z2-Z1, 2);
    double result = Math.Sqrt(move1 + move2 + move3);
    return result;
}

double moveLenght = Calculate(X1, X2, Y1, Y2, Z1, Z2);

System.Console.WriteLine($"Длина расстояния равна > {moveLenght:F3}");