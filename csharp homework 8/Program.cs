using System.Linq;

Console.WriteLine("Введите, пожалуйста, номер задачи (54,56,58,60 или 62)");
string sNum = Console.ReadLine();
if (sNum == "54")
{
    //Попытался реализовать быструю сортировку, но обойтись без Linq не смог :( а в принципе и сортировать можно было с помощью Linq

    int[,] CreateRandomArray(int rows, int columns, int min, int max)
    {
        int [,] newArray = new int[rows,columns];
        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<columns;j++)
                newArray[i,j] = new Random().Next(min,max+1);
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
        Console.WriteLine();
    }

    int[] GetRow(int[,] array,int rowNumber)
    {
        int[] rs = new int[array.GetLength(1)];
        for(int i=0;i<array.GetLength(1);i++)
        {
            rs[i] = array[rowNumber,i];
        }
        return rs;
    }

    void SetRow(int[,] array, int rowNumber, int[] row)
    {
        for(int i=0;i<array.GetLength(1);i++)
        {
            array[rowNumber,i] = row[i];
        }
    }

    int[] Concat(int[] before, int[] middle, int[] after)
    {
        int length = before.Length + middle.Length + after.Length;
        int[] rs = new int[length];
        Array.Copy(before,0,rs,0,before.Length);
        Array.Copy(middle,0,rs,before.Length,middle.Length);
        Array.Copy(after,0,rs,before.Length+middle.Length,after.Length);
        return rs;
    }

    int[] SortRow(int[] row)
    {
        if(row.Length <= 1) return row;
        else {
            int randInt = new Random().Next(0,row.Length);
            int randValue = row[randInt];
            int[] more = row.Where(x=>x>randValue).ToArray();
            int[] same = row.Where(x=>x==randValue).ToArray();
            int[] less = row.Where(x=>x<randValue).ToArray();
            return Concat(SortRow(more),same,SortRow(less));
        }
    }

    void SortArray(int[,] array)
    {
        for(int i=0;i<array.GetLength(0);i++)
        {
            int[] row = GetRow(array,i);
            row = SortRow(row);
            SetRow(array,i,row);
        }
    }

    int[,] arr = CreateRandomArray(5,5,1,9);
    ShowArray(arr);
    SortArray(arr);
    ShowArray(arr);
}  else if(sNum == "56") {
    int[,] CreateRandomArray(int rows, int columns, int min, int max)
    {
        int [,] newArray = new int[rows,columns];
        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<columns;j++)
                newArray[i,j] = new Random().Next(min,max+1);
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

    int FindMinRow(int[,] array)
    {
        int min = int.MaxValue;
        int rowNum = -1;
        for(int i=0;i<array.GetLength(0);i++)
        {
            int s = 0;
            for(int j=0;j<array.GetLength(1);j++)
            {
                s+=array[i,j];
            }
            if (s < min)
            {
                 min = s;
                 rowNum = i;
            }
        }
        Console.WriteLine($"В строке {rowNum} минимальная сумма элементов {min}");
        return min;
    }

    int[,] arr = CreateRandomArray(5,5,1,9);
    ShowArray(arr);
    int m = FindMinRow(arr);

} else if(sNum == "58") {
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

    int[,] GetMatrixProduct(int[,] matrix1, int[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            throw new Exception("Количество столбцов в первой матрице должно быть равно количеству строк во второй.");
        }

        int[,] rs = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
        for(int i=0;i<rs.GetLength(0);i++)
        {
            for(int j=0;j<rs.GetLength(1);j++)
            {
                rs[i,j] = 0;
                for(int k=0;k<matrix1.GetLength(1);k++)
                {
                    rs[i,j] += matrix1[i,k]*matrix2[k,j];
                }
            }
        }
        return rs;
    }
    int[,] matrix1 = CreateRandomArray(3,4,-9,9);
    Console.WriteLine("Первая матрица:");
    ShowArray(matrix1);
    int[,] matrix2 = CreateRandomArray(4,5,-9,9);
    Console.WriteLine("Вторая матрица:");
    ShowArray(matrix2);
    Console.WriteLine("Произведение:");
    int[,] product = GetMatrixProduct(matrix1,matrix2);
    ShowArray(product);
} else if(sNum =="60") {

    int[,,] CreateRandomArray(int d1, int d2, int d3)
    {
        int [,,] newArray = new int[d1,d2,d3];
        for(int i=0;i<d1;i++)
        {
            for(int j=0;j<d2;j++)
            {
                for(int k=0;k<d3;k++) newArray[i,j,k] = new Random().Next(11,99);
            }
        }
        return newArray;
    }

    void ShowArray(int[,,] array)
    {
        for(int i=0;i<array.GetLength(0);i++)
        {
            for(int j=0;j<array.GetLength(1);j++)
            {
                for(int k=0;k<array.GetLength(2);k++) 
                {
                    Console.Write($"{array[i,j,k]} ({i},{j},{k}) ");
                }
                Console.WriteLine();
            }
        }       
    }

    int[,,] d3Array = CreateRandomArray(2,2,2);
    ShowArray(d3Array);
} else if(sNum == "62") {
    string[,] GetSpiralArray(int d1,int d2)
    {
        string[,] rs = new string[d1,d2];
        int len = d1*d2;
        int dir = 0;//0 - направо, 1 - вниз, 2 - налево, 3 - вверх
        int ind1 = 0;
        int ind2 = 0;
        int lim1 = d1;
        int lim2 = d2;
        int lim3 = 0;
        int lim4 = 0;
        for(int i=0;i<len;i++)
        {
            if(dir == 0)
            {
                if(ind2 < lim2)
                {
                    Console.WriteLine($"Введите,пожалуйста, {i+1}-е число (из {len})");
                    rs[ind1,ind2] = $"{Console.ReadLine()} (№{i})";
                    ind2++;//двигаемся по столбцам
                } else{
                    lim3++;//сдвигаем верхнюю границу на 1 вниз(прошли строку)
                    ind1++;//прошли одну строку сверху, сдвигаемся вниз
                    ind2--;//уменьшаем номер столбца, возвращаемся в границы 
                    dir = 1;//меняем направление
                    i--;
                }
            } else if(dir == 1) {
                if(ind1 < lim1)
                {
                    Console.WriteLine($"Введите,пожалуйста, {i+1}-е число (из {len})");
                    rs[ind1,ind2] = $"{Console.ReadLine()} (№{i})";
                    ind1++;//двигаемся по строкам
                } else {
                    lim2--;//сдвигаем правую границу на 1 влево (прошли столбец)
                    ind1--;//уменьшаем номер строки, возвращаемся в границы
                    ind2--;//уменьшаем номер столбца, сдвигаемся влево
                    dir = 2;//меняем направление
                    i--;
                }
            } else if(dir == 2) {
                if(ind2 >= lim4)
                {
                    Console.WriteLine($"Введите,пожалуйста, {i+1}-е число (из {len})");
                    rs[ind1,ind2] = $"{Console.ReadLine()} (№{i})";
                    ind2--;//двигаемся по слолбцам, но теперь в обратном направлении
                } else {
                    lim1--;//сдвигаем нижнюю границу на 1 вверх (прошли строку снизу)
                    ind2++;//увеличиваем номер столбца, возвращаемся в границы
                    ind1--;//уменьшаем номер строки, сдвигаемся вверх
                    dir = 3;//меняем направление
                    i--;
                }
            } else if(dir == 3) {
                if(ind1 >= lim3)
                {
                    Console.WriteLine($"Введите,пожалуйста, {i+1}-е число (из {len})");
                    rs[ind1,ind2] = $"{Console.ReadLine()} (№{i})";
                    ind1--;//двигаемся по строкам снизу вверх
                } else {
                    lim4++;//сдвигаем левую границу на 1 вправо (прошли столбец слева)
                    ind2++;//увеличиваем номер столбца, сдвигаемся вправо
                    ind1++;//увеличиваем номер строки, возвращаемся в границы
                    dir = 0;//меняем направление
                    i--;
                }
            }
        }
        return rs;
    }

    void ShowArray(string[,] array)
    {
        for(int i=0;i<array.GetLength(0);i++)
        {
            for(int j=0;j<array.GetLength(1);j++)
                Console.Write($"{array[i,j]} ");
            Console.WriteLine();
        }
    }

    string[,] array = GetSpiralArray(4,4);
    ShowArray(array);
}