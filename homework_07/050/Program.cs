// Задача 50. Напишите программу, которая на вход принимает ЗНАЧЕНИЕ элемента в двумерном массиве, и возвращает ИНДЕКСЫ этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

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

void FindElementInArray(int[,] array, int element, out int indexRow, out int indexCol)
{
    indexRow = -1;
    indexCol = -1;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == element)
                {
                    indexRow = i;
                    indexCol = j;
                    return;
                }
        }
    }
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

int findElement = EnterDataNumber("Введите значение искомого элемента: ");
FindElementInArray (
        array: myArray, 
        element: findElement, 
        out int indexRow, 
        out int indexCol
        );

if (indexRow >= 0 && indexCol >= 0)
    Console.WriteLine($"Индексы искомого элемента: [{indexRow},{indexCol}]");
else
    Console.WriteLine("Искомого элемента в массиве нет.");