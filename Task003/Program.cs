// Напишите программу, которая принимает на вход
// координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

double distancePoints(double x1, double y1, double x2, double y2)
{
    double dist = Math.Sqrt(Math.Pow (x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return dist;           
}


double c = distancePoints(3, 6, 2, 1);
Console.WriteLine(c);
double b = distancePoints(7, -5, 1, -1);
Console.WriteLine(b);
double h = distancePoints(-4, 5, 2, -11);
Console.WriteLine(h);