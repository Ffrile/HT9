// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04 05
// 16 17 18 19 06
// 15 16 15 20 07
// 14 23 22 21 08
// 13 12 11 10 09

// должок за прошлую домашку

int[,] Generate2DArray(int m, int n, int startnum)
{
    int[,] result = new int[m, n];
    int i = 0;
    int j = 1;
    result[0, 0] = startnum;
    while (startnum < m*n)
    {
        // startnum++;
        // result[i, j] = startnum;
        if (i + j < result.GetLength(0) - 1 && i <= j + 1 && result[i, j] == 0)
        {
            startnum++;
            result[i, j] = startnum;
            j++;
        }
        else if (i < result.GetLength(1) - 1 && i < j && result[i, j] == 0)
        {
            startnum++;
            result[i, j] = startnum;
            i++;
        }
        else if (j > 0 && i >= j && result[i, j] == 0)
        {
            startnum++;
            result[i, j] = startnum;
            j--;
        }
        else if (i > 0 && result[i, j] == 0)
        {
            startnum++;
            result[i, j] = startnum;
            i--;
        }
        else 
        {
            i--;
            j++;
        }

    }
    return result;
}

void Print2DArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = Generate2DArray(10, 10, 1);
Print2DArray(array);