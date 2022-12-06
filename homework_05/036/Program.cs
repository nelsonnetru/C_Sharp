// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArrayWithRandomNumbers (int sizeArray, int leftRange, int rightRange)
{
    int[] array = new int[sizeArray];
    Random rand = new Random();
    
    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    
    return array;
}

int CountOddNumbersPosition (int[] array)
{
    int countOddPosition = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
      countOddPosition += array[i];
    }
      
    return countOddPosition;
}

Console.Clear();

const int SIZE_ARRAY = 5;
const int LEFT_RANGE = -99;
const int RIGHT_RANGE = 99;

int[] arr2 = new int[SIZE_ARRAY];
arr2 = FillArrayWithRandomNumbers(SIZE_ARRAY, LEFT_RANGE, RIGHT_RANGE);
System.Console.WriteLine("[" + string.Join(", ", arr2) + "]");

int countOddPos = CountOddNumbersPosition (arr2);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {countOddPos}");