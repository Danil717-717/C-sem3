void squareNumbers(int x)
{
    Console.Write($"{x} -> ");
    
    int index = 1;
    while(index < x)
    {
        Console.Write($"{index * index}, ");
        index++;
    }
    Console.Write($"{index * index}, ");
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

squareNumbers(num);
