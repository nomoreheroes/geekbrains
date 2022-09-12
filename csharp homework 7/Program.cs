Console.WriteLine("Введите, пожалуйста, номер задачи (47,50 или 52)");
string sNum = Console.ReadLine();
if (sNum == "47")
{
    double[,] CreateRandomArray(int rows, int columns, int min, int max)
    {
        double [,] newArray = new double[rows,columns];
        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<columns;j++)
                newArray[i,j] = new Random().NextDouble() + new Random().Next(min,max);
        }
        return newArray;
    }

    void ShowArray(double[,] array)
    {
        for(int i=0;i<array.GetLength(0);i++)
        {
            for(int j=0;j<array.GetLength(1);j++)
                Console.Write($"{array[i,j]} ");
            Console.WriteLine();
        }
    }

    ShowArray(CreateRandomArray(3,4,1,99));
}  else if(sNum == "50") {
    int [,] array = new int[3,4];
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            Console.WriteLine($"Введите, пожалуйста, элемент в {i+1}-й строке и {j+1}-м столбце");
            array[i,j] = Convert.ToInt32(Console.ReadLine());
        }
    }

    Console.WriteLine("Введите, пожалуйста, номер строки, элемент в которой будем искать");
    int searchRow = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите, пожалуйста, номер столбца, элемент в которой будем искать");
    int searchCol = Convert.ToInt32(Console.ReadLine());

    void SearchArray(int[,] array, int row, int col)
    {
        if (row >= array.GetLength(0) || col >= array.GetLength(1)) Console.WriteLine($"Элемента с позициями ({row},{col}) не существует");
        else Console.WriteLine($"Значение массива в ячейке ({row},{col})={array[row,col]}");
    }

    SearchArray(array,searchRow,searchCol);
} else if(sNum == "52") {
    int[,] CreateRandomArray(int rows, int columns, int min, int max)
    {
        int [,] newArray = new int[rows,columns];
        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<columns;j++)
                newArray[i,j] = new Random().Next(min,max);
        }
        return newArray;
    }

    void ShowArray(int[,] array)
    {
        for(int i=0;i<array.GetLength(0);i++)
        {
            for(int j=0;j<array.GetLength(1);j++)
                Console.Write($"{array[i,j]} ");
            Console.WriteLine();
        }
    }

    double[] GetColumnMeans(int[,] array)
    {
        double[] rs = new double[array.GetLength(1)];
        for(int i=0;i<array.GetLength(1);i++)
        {
            double s = 0;
            int count = 0;
            for(int j=0;j<array.GetLength(0);j++)
            {
                s += array[j,i];
                count++;
            }
            rs[i] = s/count;
        }
        return rs;
    }

    void ShowMeans(double[] arr)
    {
        for(int i=0;i<arr.Length;i++) Console.WriteLine($"Среднее по {i}-му столбцу равно {arr[i]}");
    }

    int[,] arr = CreateRandomArray(4,5,1,10);
    ShowArray(arr);
    double[] means = GetColumnMeans(arr);
    ShowMeans(means);
}