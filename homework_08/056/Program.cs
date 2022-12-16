// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2 (сумма 14)
// 5 9 2 3 (сумма 19)
// 8 4 2 4 (сумма 20)
// 5 2 6 7 (сумма 20)

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

int FindRowWithMinimalSum(int[,] arr)
{
    int findNumeberRow = 0;
    int minimalSum = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < arr.GetLength(1); j++)
            sum += arr[i, j];   // определяем сумму элементов в строке

        if (i == 0)
            minimalSum = sum;   // для нулевой строки сумму элементов зададим как начальный "эталон"

        else if (sum < minimalSum)
        {
            minimalSum = sum;
            findNumeberRow = i;
        }
    }

    return findNumeberRow;
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

PrintArray(myArray);

int minSummaryRow = FindRowWithMinimalSum(myArray);
Console.WriteLine($"\nНомер строки с наименьшей суммой элементов: {minSummaryRow + 1} строка"); // выведем номер строки, начиная с 1 (как в примере)
