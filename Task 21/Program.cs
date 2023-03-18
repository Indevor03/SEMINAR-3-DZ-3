// Напишите программу, которая 
// принимает на вход координаты двух точек
// находит расстояние между ними в 3D пространстве

int InputN(string message)
{
    System.Console.WriteLine("{message}> ");
    int value;
    if (int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

int x1 = InputN("Ввеcти координату X точки A");
int y1 = InputN("Ввести координату Y точки A");
int z1 = InputN("Ввеcти координату Z точки A");
int x2 = InputN("Ввеcти координату X точки B");
int y2 = InputN("Ввеcти координату Y точки B");
int z2 = InputN("Ввеcти координату Z точки B");

double dis(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int deltax = x2 - x1;
    int deltay = y2 - y1;
    int deltaz = z2 - z1;
    return Math.Sqrt(deltax * deltax + deltay * deltay + deltaz * deltaz);
}
System.Console.Write($"Растояние между точками A и B равно {dis(x1, y1, z1, x2, y2, z2):F2}");
