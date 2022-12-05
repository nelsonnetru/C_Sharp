// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 

// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1); // [-9; 10)
    }
    return arr;
}

int FindElements(int[] arr, int leftRange, int rightRange)
{
    // leftRange <= X <= rightRange
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= leftRange && arr[i] <= rightRange)
            sum++;
    }
    return sum;
}

Console.Clear();

int sizeArray = 123;
int[] array = new int[sizeArray];
array = FillArrayWithRandomNumbers(sizeArray, 0, 100);

Console.WriteLine("[" + string.Join(", ", array) + "]");

int colElement = FindElements(array, 10, 99);
Console.WriteLine("Найдено элементов: " + colElement);

