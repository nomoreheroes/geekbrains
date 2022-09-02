Console.WriteLine("Введите, пожалуйста, номер задачи. Возможные номера: 2,4,6,8");
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
}