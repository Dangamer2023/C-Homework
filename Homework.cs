/*Задача 54:Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] array = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

void ArrayOrder(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Задача 54 - Элементы массива в правильном порядке:");
ArrayOrder(array);



/*Задача 56:Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/


int[,] newarray = new int[4, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };

int minSum = int.MaxValue;
int minSumRow = -1;

void SumM(int[,] newarray)
{
    for (int i = 0; i < newarray.GetLength(0); i++)
    {
        int Sum = 0;
        for (int j = 0; j < newarray.GetLength(1); j++)
        {
            Sum += newarray[i, j];
        }
        if (Sum < minSum)
        {
            minSum = Sum;
            minSumRow = i;
        }
    }


}


SumM(newarray);
Console.WriteLine("Строка с наименьшей суммой элементов: " + (minSumRow + 1));

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


int[,] matrix1 = { { 2, 4 }, { 3, 2 } };
int[,] matrix2 = { { 3, 4 }, { 3, 3 } };
int[,] resultMatrix = new int[2, 2];

void Product(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    Console.WriteLine(resultMatrix[0, 0] + " " + resultMatrix[0, 1]);
    Console.WriteLine(resultMatrix[1, 0] + " " + resultMatrix[1, 1]);
}

Console.WriteLine("Задача 58 - Матрицы:");
Product(matrix1, matrix2, resultMatrix);






/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/


int[,,] Threearray = new int[2, 2, 2];
int num = 10;

void PrintArray(int[,,] Threearray)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                Threearray[i, j, k] = num;
                num++;
            }
        }
    }

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                Console.Write(Threearray[i, j, k] + "(" + i + "," + j + "," + k + ") ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Задача 60 - Вывод трехмерного массива:");
PrintArray(Threearray);





/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/




int[,] Lastarray = new int[4, 4];
int Num = 1;
int rowStart = 0;
int rowEnd = 3;
int colStart = 0;
int colEnd = 3;


void FillRowsColumns(int[,] Lastarray, int Num, int colStart, int rowStart, int colEnd, int rowEnd)
{
    while (Num <= 16)
    {
        //заполняем верхнюю строку
        for (int i = colStart; i <= colEnd; i++)
        {
            Lastarray[rowStart, i] = Num;
            Num++;
        }
        rowStart++;

        // заполняем правый столбец
        for (int i = rowStart; i <= rowEnd; i++)
        {
            Lastarray[i, colEnd] = Num;
            Num++;
        }
        colEnd--;

        // заполняем нижнюю строку
        for (int i = colEnd; i >= colStart; i--)
        {
            Lastarray[rowEnd, i] = Num;
            Num++;
        }
        rowEnd--;

        // заполняем левый столбец
        for (int i = rowEnd; i >= rowStart; i--)
        {
            Lastarray[i, colStart] = Num;
            Num++;
        }
        colStart++;
    }
}



void PrArray(int[,] Lastarray)

{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write("{0:D2} ", Lastarray[i, j]);
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Задача 62 - Спиральный массив:");
FillRowsColumns(Lastarray, Num, colStart, rowStart, colEnd, rowEnd);
PrArray(Lastarray);
