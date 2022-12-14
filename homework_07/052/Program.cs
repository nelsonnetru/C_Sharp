// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int EnterDataNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FillRandomIntArray(int[,] array, int leftRange, int rightRange)
{
    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rand.Next(leftRange, rightRange + 1);
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");

        Console.WriteLine();
    }
}

// возратит массив средних арифметических значений по столбцам заданного двумерного массива
double[] SolveAverageByColumns(int[,] array)
{
    double[] averages = new double[array.GetLength(1)];
    double summ;
    int rowsArray = array.GetLength(0);
    int columnsArray = array.GetLength(1);

    for (int j = 0; j < columnsArray; j++)
    {
        summ = 0;
        for (int i = 0; i < rowsArray; i++)
        {
            summ += array[i, j];
        }
        averages[j] = Math.Round(summ / rowsArray, 2); // округлим до 2 знаков
    }

    return averages;
}

Console.Clear();

const int leftRangeRandom = 0;
const int rightRangeRandom = 9;

int sizeM = EnterDataNumber("Введите количество строк m: ");
int sizeN = EnterDataNumber("Введите количество столбцов n: ");

int[,] myArray = new int[sizeM, sizeN];
FillRandomIntArray(
        array: myArray,
        leftRange: leftRangeRandom,
        rightRange: rightRangeRandom
        );

double[] averagesArray = SolveAverageByColumns(myArray);

PrintArray(myArray);
Console.WriteLine("\nСреднее арифметическое по столбцам");
Console.WriteLine(String.Join("\t", averagesArray));