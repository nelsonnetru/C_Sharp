// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


// метод для генерации вещественных чисел
// на выходе принудительно уменьшим точность с double до float, чтобы было поменьше 
// цифр после запятой

float[] FillArrayWithRandomFloatNumbers(int sizeArray, int leftRange, int rightRange)
  {
    Random rand = new Random();
    float[] array = new float[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = (float)(rand.NextDouble() * (rightRange - leftRange) + leftRange);
    }
      
    return array;
}
  
void FindDifferentMaxAndMin(float[] array, out float maxElement, out float minElement, out float different)
  {
    minElement = array[0];
    maxElement = array[0];

    for (int i = 0; i < array.Length; i++)
    {
    	if (array[i] < minElement) minElement = array[i];
        if (array[i] > maxElement) maxElement = array[i];
    }
      
    different = maxElement - minElement;
}

Console.Clear();

const int SIZE_ARRAY = 5;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 7;

float[] arr3 = new float[SIZE_ARRAY];
arr3 = FillArrayWithRandomFloatNumbers (SIZE_ARRAY, LEFT_RANGE, RIGHT_RANGE);
System.Console.WriteLine("[" + string.Join(", ", arr3) + "]");
    
FindDifferentMaxAndMin(arr3, out float max, out float min, out float diff);
System.Console.WriteLine($"Максимальный элемент = {max}\nМинимальный элемент = {min}\nРазница между максимальным и минимальным = {diff}");