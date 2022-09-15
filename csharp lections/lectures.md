# Конспект лекций Geekbrains по языку C#

## Почему C#? 
* Язык достаточно популярный
* Используется в самых разнообразных проектах

## Основная задача курса
* Задача - научиться программированию, т.е. умению алгоритмически 
мыслить
* Конкретный язык программирования - это всего лишь инструмент, синтаксис которого можно выучить и самостоятельно

## Что такое программа?
Программа - это набор алгоритмов, принимающих на вход какие-то данные и выдающих какой-то результат

## Установка и настройка окружения 
* Скачиваем и устанавливаем VS Code (выбираем установочный файл в зависимости от операционной системы)
* Устанавливаем расширение C# для VS Code
* Может пригодиться расширение C# Extensions

## Первое приложение C# в VS Code
* Заходим в пункт меню Explorer
* Открываем папку, в которой будем реализовывать наш проект
* Открываем новый терминал (открыть папку в интегрированном терминале)
* Вводим команду **dotnet new console** (создаются все необходимые файлы для проекта)
* Открываем файл _**Program.cs**_
* По умолчанию в этом файле содержится текст: *Console.WriteLine("Hello, World!");* Это и есть наше первое приложение.

### Комментарий к коду
В коде программы можно вводить текст, который никак не используется самой программой, но позволяет программисту делать пометки (комментарии) для себя или других программистов.

В C# для комментирования используются символы **//**:

*//Пример комментария в программе C#*

### Вывод данных в окно терминала
Для вывода данных используется команда **Console.WriteLine("текст")** (в тексте программы).

### Запуск приложения
Для запуска приложения мы используем команду **dotnet run** (в терминале)

### Полезный совет - настройка автосохранения при смене фокуса

В настройках находим параметр **AutoSave** (по умолчанию off) и устанавливаем значение **onFocusChange**.

## Пример №2: запрашиваем имя пользователя и приветствуем его

**Console.ReadLine** - считываем данные и сохраняем их в переменную. 

**Console.Write** - выводим текст в терминал без перевода строки.

Пример приложения: 

    Console.WriteLine("Введите ваше имя ");
    string username = Console.ReadLine();
    Сonsole.Write("Привет,");
    Console.Write(username);

## Пример №3: складываем два числа

### Как создавать переменные в C#?
Нужно указать тип данных и название переменной.
Примеры:

    int n = 3; //целое число
    string s = "test";//строка

Пример приложения:

    int numberA = 3;
    int numberB = 5;
    int result = numberA + numberB;
    Console.WriteLine(result);

## Пример №4: деление одного числа на другое

Деление в C# осуществляется с помощью оператора **/**.

*При делении одного целого (int) числа на другое целое мы получим результат **целочисленного** деления.*

Пример:

    int numberA = 12;
    int numberB = 5;
    Console.WriteLine(numberA / numberB);// получаем 2

Чтобы получить вещественный результат деления, нам нужно указать тип переменных **double**.

Пример:

    double numberA = 12;
    double numberB = 5;
    Console.WriteLine(numberA / numberB);// получаем 2.4


## Разные типы данных занимают разный размер памяти

**bool** - тип данных для логичеких переменных

|Тип переменной | Память |
|---------------|--------|
|int|32-разрядное целое число со знаком|
|double|64-разрядное целое число со знаком|
|string|от 4 байт до 2 гб|
|bool|1 байт|

## Операторы в С#
|Оператор|Операция|
|--------|--------|
|+|Сложение|
|-|Вычитание|
|/|Деление|
|*|Умножение|
|%|Вычисление остатка|
|()|Скобки, меняем приоритет операций|

## Генерация псевдослучайных чисел

Чтобы получить псевдослучайное число в диапазоне от *min* до *max*, мы используем команду **new Random().Next(min,max+1)**

## Пример №5: сложение двух случайных чисел

    int numberA = new Random().Next(1,10);
    int numberB = new Random().Next(1,10);
    int result = numberA + numberB;
    Console.WriteLine(result);

## Пример №6: ветвление программы

Если нам нужно, чтобы программа выполнялась по разному при разных условиях, мы используем оператор **if**:

    if(условие) {
        действие 1
    } else {
        действие 2
    }

Метод **string.ToLower** переводит строку в нижний регистр:

    username.ToLower();

Пример приложения:

    Console.Write("Введите имя пользователя:");
    string username = Console.ReadLine();
    if(username.ToLower() == "маша")
    {
        Console.WriteLine("Ура, это же МАША!");
    } else {
        Console.Write("Привет, ");
        Console.WriteLine(username);
    }

## Пример №7: решение задачи с гирями

    int a = 1;
    int b = 2;
    int c = 6;
    int d = 8;
    int e = 4;

    int max = a;
    if(a > max) max = a;
    if(b > max) max = b;
    if(c > max) max = c;
    if(d > max) max = d;
    if(e > max) max = e;

    Console.Write("max = ");
    Console.WriteLine(max);

## Пример №8: задача про точки (треугольник Серпинского)

Чтобы очистить терминал можно использовать метод **Console.Clear()**.

Чтобы установить произвольную позицию курсора, можно использовать метод **Console.SetCursorPosition(столбец, строка)**

Синтаксис циклов:

    while(УСЛОВИЕ ПРОДОЛЖЕНИЯ)
    {
        Набор действий
    }

Выполняем следующий алгоритм:
1. Определить три точки
2. Выбрать две любых
3. Найти середину
4. Поставить точку
5. Выбрать случайную вершину треугольника
6. Соединить ее с полученной на 4 шаге точкой
7. Перейти к шагу 3
8. Повторить шаги 3-7

Пример приложения:

    Console.Clear()

    int xa = 1, ya = 1, xb = 1, yb = 30, xc = 40, yc = 30;

    Console.SetCursorPosition(xa,ya);
    Console.WriteLine("+");
    Console.SetCursorPosition(xb,yb);
    Console.WriteLine("+");
    Console.SetCursorPosition(xc,yc);
    Console.WriteLine("+");

    int count = 0;
    while(count < 1000) 
    {
        int what = new Random().Next(0,3);
        if (what == 0) 
        {
            x = (x+xa)/2;
            y = (y+ya)/2;
        }

        if (what == 1) 
        {
            x = (x+xb)/2;
            y = (y+yb)/2;
        }

        if (what == 2) 
        {
            x = (x+xc)/2;
            y = (y+yc)/2;
        }

        Console.SetCursorPosition(x,y);
        Console.WriteLine("+");
        count++;
    }

## Функции (методы) в C#
Функция - это часть программного кода, к которому можно обращаться несколько раз с разными параметрами (аргументами).
Функция это "коробка" в которую передаются параметры и которая выдает результат.
В C# нет обычных функций, есть только методы.

Примеры:
* Next(1,10);
* WriteLine();

**Основные элементы функции:**
* Имя (идентификатор) функции
* Входные параметры  (необязательно)
* Может возвращать значение (необязательно)

**Как выглядит функция в C#?**

    ВозвращаемыйТипДанных ИмяМетода(ТипДанных1 ИмяАргумента1,...)
    {
        ТелоМетода
        return ЗначениеСоответствующееВозвращаемомуТипуДанных;
    }

Пример функции:

    double double(x)
    {
        double result = x*x+1;
        return result;
    }

### Виды методов:
* Методы, которые ничего не принимают и ничего не возвращают
* Методы, которые принимают аргументы, но ничего не возвращают
* Методы, которые ничего не принимают, но возвращают значение
* Методы, которые принимают аргументы и возвращают значение

**Можно передавать в метод _именованные аргументы_**:

    void Message(string msg,int count)
    {
        //тело метода
    }

    Message(count:1,msg:"Сообщение");


### Задача №9: найти максимум из 9 чисел

    int Max(int arg1, int arg2, int arg3)
    {
        int result = 0;
        if (arg1 > result) result = arg1;
        if (arg2 > result) result = arg2;
        if (arg3 > result) result = arg3;
        return result;
    }

    int max1 = Max(a,b,c);
    int max2 = Max(d,e,f);
    int max3 = Max(g,h,i);
    int max = Max(max1,max2,max3);
    Console.WriteLine(max);

## Массивы 
Массив - это тип данных, в котором содержится несколько элементов по порядку. 

У каждого элемента массива есть индекс (номер, который начинается с 0);

*Как задается массив?*
* ТИП_ДАННЫХ[] имя = {значение1, значение2,..}
* int[] array = {0,1,4,2...}
* int[] array = new int[] {0,1,4,2...}
* int[] array = new int[5] {1,0,2,0,3}

*Как получить элемент массива по индексу?*
    
    int elem = array[index];

*Как получить размер массива?*

    int len = array.Length;

### Задача №10: найти максимум в массиве из 9 чисел

    int[] array = {11,21,23,32,545,23,3,2,5};
    int result = Max(
        Max(array[0],array[1],array[2]),
        Max(array[3],array[4],array[5]),
        Max(array[6],array[7],array[8])
    );
    Console.WriteLine(result);

### Задача №11: Поиск элемента в массиве

    int array[] = {1,12,31,4,15,16,17,18};
    int n = array.Length;
    int find = 4;
    int index = 0;
    while(index < n)
    {
        if (array[index] == find)
        {
            Console.WriteLine(index);
            index++;
        }
    }

### Задача №12: Заполнение массива случайными числами и вывод массива

    int array[] = new int[10];

    void FillArray(int[] collection)
    {
        int length = collection.Length;
        int index = 0;
        while(index < length)
        {
            collection[index] = new Random().Next(1,10);
            index++;
        }
    }

    void PrintArray(int[] col)
    {
        int count = col.Length;
        int position =0;
        while(position < count)
        {
            Console.WriteLine(col[position]);
            position++;
        }
    }

    FillArray(array);
    PrintArray(array);

### Задача №13: Поиск элемента в массиве с помощью метода

    int IndexOf(int[] collection,int find)
    {
        int count = collection.Length;
        int index = 0;
        int position =-1;

        while(index < count)
        {
            if(collection[index] == find)
            {
                position = index;
            }
            index++;
        }
        return position;
    }


## Циклы в C#

* While
* For
* Do While

Синтаксис цикла **for**:

    for(int i=0;i<10;i++)
    {
        Console.WriteLine(i);
    }

### Задача №14: Вывод таблицы умножения на экран

    for(int i=2;i<=10;i++)
    {
        for(int j=2; j<=10;j++)
        {
            Console.WriteLine($"{i}X{j}={i*j}")
        }
        Console.WriteLine();
    }

### Задача №15: Заменить символы в строке

    string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
    + "ежели бы вас послали вместо нашего милого "
    + "Винценгероде, вы бы взяли приступом согласие " 
    + "прусского короля. Вы так красноречивы. Вы "
    + "дадите мне чаю?";

    string Replace(string text, char oldValue,char newValue)
    {
        string result = String.Empty;
        int length = text.Length;
        for(int i=0;i<length;i++)
        {
            if(text[i] == oldValue) result += $"{newValue}";
            else result = result + $"{text[i]}";
        }
        return result;
    }

    string new_text = Replace(text," ","|");

### Задача №16: сортировка массива

    int[] arr = {1,5,4,3,2,1,4,5}

    void SelectionSort(int[] array)
    {
        for(int i=0;i<array.Length;i++)
        {
            int minPosition = i;
            for(int j=i+1;j<length;j++)
            {
                if(array[i] < array[minPosition]) minPosition = j;
            }            
            int temp = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temp;
        }
    }