Console.WriteLine("Введите, пожалуйста, номер задачи (64,66 или 68)");
string sNum = Console.ReadLine();
if (sNum == "64")
{
    Console.WriteLine("Введите число M");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число N");
    int n = Convert.ToInt32(Console.ReadLine());

    void GetAllNumbers(int m, int n)
    {
        if (m > n) Console.WriteLine("N должно быть больше, чем M");
        if (n < 1) Console.WriteLine($"Нет натуральных чисел меньше, чем N ({n})");
        if (m < 1) m = 1;
        for (int i=m;i<=n;i++) Console.WriteLine(i);
    }

    GetAllNumbers(m,n);

}  else if(sNum == "66") {
    Console.WriteLine("Введите число M");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число N");
    int n = Convert.ToInt32(Console.ReadLine());

    void GetSum(int m, int n)
    {
        if (m > n) Console.WriteLine("N должно быть больше, чем M");
        if (n < 1) Console.WriteLine($"Нет натуральных чисел меньше, чем N ({n})");
        if (m < 1) m = 1;
        Console.WriteLine(n*(n+1)/2 - (m-1)*m/2);
    }

    GetSum(m, n);

} else if(sNum == "68") {
    Console.WriteLine("Введите число M");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число N");
    int n = Convert.ToInt32(Console.ReadLine());

    int Akkerman(int m, int n)
    {   
        if(n == 0) return m+1;
        else if (n > 0 && m == 0) return Akkerman(1,n-1);
        else return Akkerman(Akkerman(m-1,n),n-1);
    }

    int rs = Akkerman(m,n);
    Console.WriteLine($"Значение функции Аккермана: {rs}");
}