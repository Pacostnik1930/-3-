//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double InputInt()
{
    Console.WriteLine("Введите координаты первой точки");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты второй точки");
    double b = double.Parse(Console.ReadLine());
    bool isNumber = double.TryParse(Console.ReadLine(), out double number);
    if (isNumber)
    {
        return number;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение");
        return -1;
    }

}

double ax = InputInt();
double ay = InputInt();
double az = InputInt();
double bx = InputInt();
double by = InputInt();
double bz = InputInt();

double GetDistanceBetweenTwoPoints(double ax, double ay, double bx, double by, double zx, double zy)
{
    double ab = Math.Round(Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2)));
    return ab;
}

double result = GetDistanceBetweenTwoPoints(ax, ay, az, bx, by, bz);

Console.WriteLine(result);