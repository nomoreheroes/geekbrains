Console.WriteLine("Введите, пожалуйста, номер задачи (25, 27 или 29).");
string sTaskNum = Console.ReadLine();
if (sTaskNum == "25") 
{
    //Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    double GetPow(double num, int pow) 
    {
        double rs = num;
        while(pow > 1) 
        {
            rs = rs*num;
            pow--;
        }
        return rs;
    }

    Console.WriteLine("Введите, пожалуйста, число, которое нужно возвести в степень");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите, пожалуйста, степень");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Результат вычислений: {GetPow(a,b)}");
} else if (sTaskNum == "27") {
    //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    int GetSum(int num)
    {
        int rs = 0;
        while (num > 0)
        {
            rs += num % 10;
            num = num/10;
        }
        return rs;
    }
    Console.WriteLine("Введите, пожалуйста, число, сумму цифр которого надо посчитать");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Результат вычислений: {GetSum(a)}");
} else if (sTaskNum == "29") {
    //Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    int[] CreateArray(int num) 
    {
        int[] rs = new int[num];
        for(int i=0;i<rs.Length;i++)
        {
            rs[i] = new Random().Next(0,100);
        }
        return rs;
    }

    void PrintArray(int[] arr)
    {
        string s = string.Join(",", arr);
        Console.WriteLine($"[{s}]");
    }

    Console.WriteLine("Введите, пожалуйста, сколько чисел должно быть в массиве");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Результат вычислений:"); 
    PrintArray(CreateArray(a));
}