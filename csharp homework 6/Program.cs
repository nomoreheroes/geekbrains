    Console.WriteLine("Введите, пожалуйста, номер задачи (41 или 43)");
    string sNum = Console.ReadLine();

    if(sNum == "41")
    {
        int stop = 0;
        int counter1 = 1;
        int counter2 = 0;
        int num;
        while(stop == 0)
        {
            Console.WriteLine($"Введите, пожалуйста, число №{counter1}. Введите 'stop', чтобы завершить");
            string s = Console.ReadLine();
            if (s == "stop")
            {
                stop = 1;
                break;
            } else {
                num = Convert.ToInt32(s);
                if (num > 0) counter2++;
            }
            counter1++;
        }
        Console.WriteLine($"Количество положительных чисел:{counter2}");
    } else if(sNum == "43") {
        void PrintArray(double[] arr)
        {
            string s = string.Join(",", arr);
            Console.WriteLine($"[{s}]");
        }

        double[] FindIntersection(double b1,double k1,double b2,double k2)
        {
            double[] intersection = new double[2];
            intersection[0] = (b2-b1)/(k1-k2);
            intersection[1] = k1*intersection[0] + b1;
            return intersection;
        }

        Console.WriteLine($"Введите, пожалуйста, угловой коэффициент (k1) первой прямой. ");
        double k1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Введите, пожалуйста, сдвиг (b1) первой прямой от оси Ox.");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Введите, пожалуйста, угловой коэффициент (k2) второй прямой. ");
        double k2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Введите, пожалуйста, сдвиг (b2) второй прямой от оси Ox.");
        double b2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Точка пересечения двух прямых:");
        PrintArray(FindIntersection(b1,k1,b2,k2));
    }