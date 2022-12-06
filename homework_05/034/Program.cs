// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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
  
int CountPositiveNumbers (int[] array)
{
    int countPositive = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 0) countPositive++;
    }

    return countPositive;
}

Console.Clear();

const int SIZE_ARRAY = 5;
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 999;

int[] arr = new int[SIZE_ARRAY];
arr = FillArrayWithRandomNumbers(SIZE_ARRAY, LEFT_RANGE, RIGHT_RANGE);

System.Console.WriteLine("[" + string.Join(", ", arr) + "]");

int countPositive = CountPositiveNumbers(arr);
System.Console.WriteLine($"Количество четных чисел в массиве: {countPositive}");