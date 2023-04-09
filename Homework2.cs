void Matx()
{
    int m = 3, n = 4;
    double[,] array1 = new double[m, n];

    // Заполнение матрицы случайными вещественными числами
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array1[i, j] = rand.NextDouble() * 20 - 10; // генерация случайного числа от -10 до 10
            Console.Write($"{array1[i, j],4:F1} "); // вывод числа с одним знаком после запятой
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Задача 47");
Matx();



void ItemPosition()
{
    int[,] array2 = {
            {2, 8, 9, 6},
            {5, 7, 14, 32},
            {19, 23, 45, 12}
        };

    int element = Convert.ToInt32(Console.ReadLine());
    bool isFound = false;
    int row = 0, col = 0;

    // Поиск элемента
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            if (array2[i, j] == element)
            {
                isFound = true;
                row = i;
                col = j;
                break;
            }
        }
        if (isFound) break;
    }

    // Вывод результата
    if (isFound)
    {
        Console.WriteLine($"Элемент {element} находится в позиции [{row}, {col}].");
    }
    else
    {
        Console.WriteLine($"Элемента {element} в массиве нет.");
    }
}

Console.WriteLine("Задача 50");
Console.WriteLine("Введите элемент для поиска в массиве");
ItemPosition();


int[,] array3 = {
            {2, 8, 9, 5},
            {4, 19, 21, 3},
            {7, 4, 2, 4}
        };





 void PrintArray(int[,] array3)
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
            Console.Write($"{array3[i, j],3}\t");
        Console.WriteLine();
    }
}



void Average()
{

    double[] avgArr = new double[array3.GetLength(1)];

    // Вычисление среднего арифметического для каждого столбца
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array3.GetLength(0); i++)
        {
            sum += array3[i, j];
        }
        avgArr[j] = sum / array3.GetLength(0);
    }

    // Вывод результата
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        Console.WriteLine($"Среднее арифметическое столбца {j + 1} равно {avgArr[j]:F1}");
    }
}

Console.WriteLine("Задача 52");
Console.WriteLine("Ваш массив:");
PrintArray(array3);
Average();
