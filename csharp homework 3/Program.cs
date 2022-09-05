Console.WriteLine("Введите, пожалуйста, номер задачи (19, 21 или 23).");
string sTaskNum = Console.ReadLine();
if (sTaskNum == "19") 
{
    Console.WriteLine("Программа проверяет, является ли пятизначное число палиндромом.");

    void TestNum(string num)
    {
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] != num[num.Length-1-i]) Console.WriteLine("Нет, не палиндром");
            return;
        }
        Console.WriteLine("Палиндром!");
    }

    Console.WriteLine("Введите, пожалуйста, пятизначное число");
    string sNum = Console.ReadLine();
    
    if (sNum.Length != 5) 
    {
        throw new Exception("Число должно быть пятизначным!");
    } else {
        TestNum(sNum);
    }

} else if (sTaskNum == "21") {
    Console.WriteLine("Программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве");
    Console.WriteLine("Введите, пожалуйста, координату X первой точки");
    double xA = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите, пожалуйста, координату Y первой точки");
    double yA = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите, пожалуйста, координату Z первой точки");
    double zA = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите, пожалуйста, координату X второй точки");
    double xB = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите, пожалуйста, координату Y второй точки");
    double yB = Convert.ToDouble(Console.ReadLine());    
    Console.WriteLine("Введите, пожалуйста, координату Z второй точки");
    double zB = Convert.ToDouble(Console.ReadLine());

    void GetDistance(double[] point1, double[] point2)
    {
        double sum = 0.0;
        for(int i=0;i<point1.Length;i++) 
        {
            sum += Math.Pow(point1[i]-point2[i],2);
        }
        Console.WriteLine($"Расстояние между двумя точками: {Math.Sqrt(sum)}");
    }

    double[] p1 = {xA,yA,zA};
    double[] p2 = {xB,yB,zB};
    GetDistance(p1,p2);

} else if (sTaskNum == "23") {
    Console.WriteLine("Программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

    void GetCubes(int n)
    {
        int counter = 0;
        while(counter <= n) 
        {
            Console.WriteLine($"{counter}^3 = {Math.Pow(counter,3)}");
            counter++;
        }
    }
    Console.WriteLine("Введите, пожалуйста, число");
    int num = Convert.ToInt32(Console.ReadLine());
    GetCubes(num);
}