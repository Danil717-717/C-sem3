// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

void squareNumbers(int x)
{
    Console.Write($"{x} -> ");
    
    int index = 1;
    while(index < x)
    {
        Console.Write($"{index * index * index}, ");
        index++;
    }
    Console.Write($"{index * index * index}, ");
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

squareNumbers(num);