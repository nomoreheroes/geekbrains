Console.WriteLine("Введите, пожалуйста, номер задачи. Возможные номера: 2,4,6,8 (первый семинар),10,13,15 (второй семинар)");
string sNum = Console.ReadLine();

if (sNum == "2")
{
    // Task 2
    Console.WriteLine("Введите, пожалуйста, первое число");
    int a = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Введите, пожалуйста, второе число");
    int b = Int32.Parse(Console.ReadLine());
    Console.WriteLine($"Максимальное число: {(a>b?a:b)}");
} else if (sNum == "4") {
    // Task 4
    Console.WriteLine("Введите, пожалуйста, первое число");
    int a = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Введите, пожалуйста, второе число");
    int b = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Введите, пожалуйста, третье число");
    int c = Int32.Parse(Console.ReadLine());
    int max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    Console.WriteLine($"Максимальное число: {max}");
} else if (sNum == "6") {
    // Task 6
    Console.WriteLine("Введите, пожалуйста, число");
    int a = Int32.Parse(Console.ReadLine());
    if (a%2 == 0) Console.WriteLine($"Число {a} является четным.");
    else Console.WriteLine($"Число {a} является нечетным.");
} else if (sNum == "8") {
       // Task 8
    Console.WriteLine("Введите, пожалуйста, число");
    int a = Int32.Parse(Console.ReadLine());
    int start = 1;
    Console.WriteLine($"Четные числа от 1 до {a} включительно");
    while (start <= a)
    {
        if (start%2 == 0) Console.WriteLine(start);
        start++;
    }
} else if (sNum == "10") {
    void ShowSecondDigit(int num) 
    {
        if (num > 999 || num < 100) 
        {
            Console.WriteLine("Нужно ввести именно трехзначное целое число.");
        } else {
            Console.WriteLine($"Вторая цифра вашего числа = {num / 10 % 10}");
        }
    }
    Console.WriteLine("Введите, пожалуйста, трехзначное число.");
    int n = Int32.Parse(Console.ReadLine());
    ShowSecondDigit(n);
} else if (sNum == "13") {
    void ShowThirdDigit(int num) 
    {
        if (num < 100) 
        {
            //Если число двузначное и меньше, значит в нем третьей цифры нет
            Console.WriteLine("В вашем числе нет третьей цифры.");
        } else {
            //количество цифр в числе
            int totalDigits = num.ToString().Length;
            //число 10 в 
            //получаем отстаток от деления числа на 10 в степени равной количеству цифр в числе минус 2,
            //и делим этот остаток на 10 в степени, равно количеству цифр в числе минус 3.
            int res = num % Convert.ToInt32(Math.Pow(10,totalDigits-2));
            int thirdNum = res / Convert.ToInt32(Math.Pow(10,totalDigits-3));
            Console.WriteLine($"Третья цифра вашего числа = {thirdNum}");
            //очень неудобно, что в C# нет оператора возведения в степень
            //легкий способ был бы такой: Int32.Parse(num.ToString()[2]), но не в рамках того, что было на семинаре
        }
    }
    Console.WriteLine("Введите, пожалуйста, любое целое число.");
    int n = Int32.Parse(Console.ReadLine());
    ShowThirdDigit(n);
} else if(sNum == "15") {
    void IsDayOff(int dayNum)
    {
        if (dayNum == 6 || dayNum == 7)
        {
            Console.WriteLine("Сегодня выходной!");
        } else {
            Console.WriteLine("Ничем не могу порадовать.");
        }
    }
    Console.WriteLine("Введите, пожалуйста, номер сегодняшнего дня");
    int d = Int32.Parse(Console.ReadLine());
    if (d < 1 || d > 7) Console.WriteLine("Расматриваем стандартную земную неделю");
    IsDayOff(d);
}