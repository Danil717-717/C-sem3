// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел от 1 до N.

void squareNumber(int x)
{
    Console.Write($"{x} -> ");

    int i = 1;
    while(i < x)
    {
        Console.Write($"{i * i},  " );
        i++;
    }

    Console.WriteLine($"{x * x}, ");    
}

squareNumber(5);
squareNumber(2);
squareNumber(6);
squareNumber(9);