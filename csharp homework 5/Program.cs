Console.WriteLine("Введите, пожалуйста, номер задачи (34, 36 или 38).");
string sTaskNum = Console.ReadLine();
if (sTaskNum == "34") 
{
    //Задайте массив заполненный случайными положительными трёхзначными числами. 
    //Напишите программу, которая покажет количество чётных чисел в массиве.
    int CreateDigits(int num_len)
    {
        int rs = 0;
        int temp;
        while(num_len > 0)
        {
            if(rs == 0) temp = new Random().Next(1,10);
            else temp = new Random().Next(0,10);
            for(int i=1;i<num_len;i++) 
            {
                temp = temp*10;
            }
            rs = rs + temp;
            num_len--;
        }
        return rs;
    }

    int[] CreateArray(int size, int num_len)
    {
        int[] rs = new int[size];
        for(int i=0;i<rs.Length;i++) 
        {

            rs[i] = CreateDigits(num_len);
        }
        return rs;
    }

    int CountEven(int[] array)
    {
        int counter = 0;
        for(int i=0;i<array.Length;i++)
        {
            if(array[i]%2==0)
            {
                counter++;
            }
        }
        return counter;
    }

    void PrintArray(int[] arr)
    {
        string s = string.Join(",", arr);
        Console.WriteLine($"[{s}]");
    }

    Console.WriteLine("Введите, пожалуйста, размер массива");
    int a = Convert.ToInt32(Console.ReadLine());
    int[] arr = CreateArray(a,3);
    Console.WriteLine("Посмотрим на массив, который получился:");
    PrintArray(arr);
    Console.WriteLine($"Количество четных чисел в нашем массиве = {CountEven(arr)}");

} else if (sTaskNum == "36") {
    //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

    int[] CreateArray(params int[] values)
    {
        int[] rs = new int[values.Length];
        for(int i=0;i<rs.Length;i++) rs[i] = values[i];
        return rs;
    }

    int GetOddPosSum(int[] arr)
    {
        int sum = 0;
        for(int i=0;i<arr.Length;i++)
        {
            if(i % 2 != 0) sum += arr[i]; 
        }
        return sum;
    }

    void PrintArray(int[] arr)
    {
        string s = string.Join(",", arr);
        Console.WriteLine($"[{s}]");
    }

    int stop = 0;
    int counter = 1;
    int[] array = new int[0];
    while(stop == 0)
    {
        Console.WriteLine($"Введите, пожалуйста, {counter} элемент массива. Введите 'stop', чтобы завершить");
        string s = Console.ReadLine();
        if (s == "stop")
        {
            stop = 1;
            break;
        } else {
            int el = Convert.ToInt32(s);
            Console.Write(el);
            int[] newarr = new int[array.Length + 1];
            for(int i=0;i<array.Length;i++)
            {
                newarr[i] = array[i];
            }
            newarr[array.Length] = el;
            array = newarr;
        }
        counter++;
    }
    Console.WriteLine("Посмотрим, какой массив у нас получился:");
    PrintArray(array);
    Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях: {GetOddPosSum(array)}");

} else if (sTaskNum == "38") {
    //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

    double GetSpread(double[] arr)
    {
        double min = double.MaxValue;
        double max = double.MinValue;
        for (int i=0;i<arr.Length;i++)
        {
            if (arr[i] < min) min = arr[i];
            if (arr[i] > max) max = arr[i];
        }
        return max - min;
    }

    int stop = 0;
    int counter = 1;
    double[] array = new double[0];
    while(stop == 0)
    {
        Console.WriteLine($"Введите, пожалуйста, {counter} элемент массива. Введите 'stop', чтобы завершить");
        string s = Console.ReadLine();
        if (s == "stop")
        {
            stop = 1;
            break;
        } else {
            double el = Convert.ToDouble(s);
            Console.Write(el);
            double[] newarr = new double[array.Length + 1];
            for(int i=0;i<array.Length;i++)
            {
                newarr[i] = array[i];
            }
            newarr[array.Length] = el;
            array = newarr;
        }
        counter++;
    }

    void PrintArray(double[] arr)
    {
        string s = string.Join(",", arr);
        Console.WriteLine($"[{s}]");
    }

    Console.WriteLine("Посмотрим, какой массив у нас получился:");
    PrintArray(array);
    Console.WriteLine($"Разница между максимумом и минимумом: {GetSpread(array)}");
}