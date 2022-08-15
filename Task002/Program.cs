// Напишите программу, которая по заданному 
// номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

void pointRange(int x)
{
    if (x == 1)
        System.Console.WriteLine("Диапазон координат точек x>0 y>0");
        //System.Console.WriteLine($"Точка ({x};{y}) в 1 четверти");
    else if (x == 2)
        System.Console.WriteLine("Диапазон координат точек x<0 y>0");
        //System.Console.WriteLine($"Точка ({x};{y}) во 2 четверти");
    else if (x == 3)
        System.Console.WriteLine("Диапазон координат точек x<0 y<0");
        //System.Console.WriteLine($"Точка ({x};{y}) в 3 четверти");
    else if (x == 4)
        System.Console.WriteLine("Диапазон координат точек x>0 y<0");
        //System.Console.WriteLine($"Точка ({x};{y}) в 4 четверти"); 
    else
        System.Console.WriteLine("Точка на координатной оси");               
}

pointRange(1);
pointRange(2);
pointRange(3);
pointRange(4);