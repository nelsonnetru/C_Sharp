// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountUpZeroNumbers (int[] arr)
{
    int counter = 0;
    for (int i = 0 ; i < arr.Length; i++)
    {
      if (arr[i] > 0) counter++;
    }

    return counter;
}

Console.Clear();

int numbersM = 5;
int[] enterNumbersArray = new int[numbersM];
    
for (int i = 0; i < numbersM; i++)
{
	Console.Write($"Введите число [{i+1}]: ");
	enterNumbersArray[i] = int.Parse(Console.ReadLine());
}

int count = CountUpZeroNumbers(enterNumbersArray);

if (count > 0)
	Console.WriteLine("Количество чисел > 0 : " + count);
else
	Console.WriteLine("Нет чисел > 0");