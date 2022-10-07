// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

double CoordinatesX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double CoordinatesY(double k1, double b1, double x)
{
    double y = k1 * x + b1;
    return y;
}

Console.WriteLine("Задайте коэффициенты уравнения (y=k1*x+b1) для прямой 1 ");
double k1 = ReadData("k1=");
double b1 = ReadData("b1=");
Console.WriteLine("Задайте коэффициенты уравнения (y=k2*x+b2) для прямой 2 ");
double k2 = ReadData("k2=");
double b2 = ReadData("b2=");
double coordX = CoordinatesX(k1, b1, k2, b2);
double coordY = CoordinatesY(k1, b1, coordX);
PrintData("Координта Х точки пересечения ", coordX.ToString());
PrintData("Координта Y точки пересечения ", coordY.ToString());
