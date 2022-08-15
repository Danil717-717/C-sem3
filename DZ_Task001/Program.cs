//  Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

void palindrom()
        {
        //int a = new Random().Next(10000, 100000);
        Console.Write("Введите 5значное число: ");
        int a = Convert.ToInt32(Console.ReadLine()); 
        int x1 = a / 10000 % 10;
        int x2 = a / 1000 % 10;
        int y1 = a / 10 % 10;
        int y2 = a % 10;
        int n5 = a / 10000;
        
            if (n5 < 1 || n5 > 9)
            {
            Console.WriteLine(a + " -> " + "Не 5значное число");
            }
            else if  (x1 == y2 && x2 == y1)
            {
            Console.WriteLine(a + " -> Да, это палиндром");
            }
            else
            {
            Console.WriteLine(a + " -> Нет, это не палиндром");
            }
        }
        for (int i = 0; i < 5; i++)
        { 
            palindrom();
    }