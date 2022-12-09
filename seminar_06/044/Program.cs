// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа 
// Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();
int N = 7;

int[] arr = new int[N];
arr[1] = arr[2] = 1;

for (int i = 3; i < arr.Length; i++)
{
	arr[i] = arr[i-1] + arr[i-2];
}

Console.WriteLine(String.Join(", ", arr));