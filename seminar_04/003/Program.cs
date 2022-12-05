// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//  Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//  Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int[] Multiplayer(int[] oldArray, int newSizeArray)
{
    int[] newArray = new int[newSizeArray];

    for (int i = 0; i < oldArray.Length / 2; i++)
    {
        newArray[i] = oldArray[i] * oldArray[oldArray.Length - 1 - i];
    }

    if (oldArray.Length % 2 != 0)
    {
        newArray[newArray.Length - 1] = oldArray[oldArray.Length / 2];
    }
    return newArray;
}

Console.Clear();

int sizeArray = 7;

int[] array = new int[sizeArray];
array = FillArrayWithRandomNumbers(sizeArray, 0, 10);

// int[] array = {1, 2, 3, 4, 5, 6, 7};

Console.WriteLine("Исходный: [" + string.Join(", ", array) + "]");

int newSizeArray = array.Length / 2 + array.Length % 2;
int[] newArray = new int[newSizeArray];

newArray = Multiplayer(array, newSizeArray);
Console.WriteLine("Результат: [" + string.Join(", ", newArray) + "]");