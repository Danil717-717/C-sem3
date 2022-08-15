// Напишите программу, которая принимает 
// на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
//в которой находится эта точка.

void FindQuarter(int x, int y)
{
    if (x > 0 && y > 0)
        //System.Console.WriteLine("1 четверть");
        System.Console.WriteLine($"Точка ({x};{y}) в 1 четверти");
    else if (x < 0 && y > 0)
        //System.Console.WriteLine("2 четверть");
        System.Console.WriteLine($"Точка ({x};{y}) во 2 четверти");
    else if (x < 0 && y < 0)
        //System.Console.WriteLine("3 четверть");
        System.Console.WriteLine($"Точка ({x};{y}) в 3 четверти");
    else if (x > 0 && y < 0)
        //System.Console.WriteLine("4 четверть");
        System.Console.WriteLine($"Точка ({x};{y}) в 4 четверти"); 
    else
        System.Console.WriteLine("Точка на координатной оси");               
}

FindQuarter(4, 7);
FindQuarter(-19, 7);
FindQuarter(-1, -3);
FindQuarter(4, -8);
FindQuarter(4, 0);
