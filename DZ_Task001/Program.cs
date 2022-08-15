// : Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

void palindrom()
        {
        //int a = new Random().Next(10000, 100000);
        Console.Write("Введите 5значное число: ");
        int a = Convert.ToInt32(Console.ReadLine()); 
        int num1 = a / 10000 % 10;
        int num2 = a / 1000 % 10;
        int rev1 = a / 10 % 10;
        int rev2 = a % 10;
        int nul = a / 10000;
        
            if (nul < 1 || nul > 9){
            Console.WriteLine(a + " -> " + "Не 5значное число");
            }
            else if  (num1 == rev2 && num2 == rev1){
            Console.WriteLine(a + " -> Да, это палиндром");
            }
            else{
            Console.WriteLine(a + " -> нет, это не палиндром");
            }
        }
        for (int i = 0; i < 10; i++)
        { 
            palindrom();
    }