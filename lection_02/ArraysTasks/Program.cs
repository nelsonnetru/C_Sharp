// Упражнение 1
// Напишите программу, в которой определен массив из пяти чисел, инициализируйте массив 
// какими-нибудь значениями и выведите значения массива на консоль в одну строку с помощью цикла for.
Console.Clear();
int[] array01 = {3, 5, 6, 1, 7};
for (int i = 0; i < array01.Length; i++)
{
    Console.Write(array01[i]+ " ");
}

// Упражнение 2
// Определите массив из 8 чисел, инициализируйте его какими-нибудь значениями и получите среднее 
// арифметическое элементов массива.
Console.WriteLine();
int[] array02 = {5, 6, 2, 8, 9, 4, 0, 66, 0};
int sum = 0;
int index = 0;
int length = array02.Length;

while (index < length)
{
    sum += array02[index];
    Console.Write(array02[index]+ " ");
    index++;
}
// в C деление целого числа на целое число в ответе даст ЦЕЛОЕ ЧИСЛО!
// чтобы получить необходимый тип, указанный слева, в данном случае float, необходимо
// правую часть преобразовать в этот же тип
float sredneeArifmFloat = Convert.ToSingle(sum) / Convert.ToSingle(array02.Length);
double sredneeArifmDouble = Convert.ToDouble(sum) / Convert.ToDouble(array02.Length);
decimal sredneeArifmDecimal = Convert.ToDecimal(sum) / Convert.ToDecimal(array02.Length);

Console.WriteLine();
Console.WriteLine($"Среднее арифметическое {sum} / {array02.Length}");
Console.WriteLine($"Среднее арифметическое float (точность 6-9 цифр): {sredneeArifmFloat}");
Console.WriteLine($"Среднее арифметическое double (точность 15-17 цифр): {sredneeArifmDouble}");
Console.WriteLine($"Среднее арифметическое decimal (точность 28-29 цифр): {sredneeArifmDecimal}");



// Упражнение 3
// Напишите программу, в которой определен числовой массив из 5 элементов, значения для которых 
// вводятся с клавиатуры в цикле. Рассчитайте сумму всех четных элементов этого массива.

int[] array03 = new int[5];
int summEvens = 0;
for (int i = 0; i < array03.Length; i++)
{
    Console.Write($"Введите значение элемента [{i}]: ");
    array03[i] = Convert.ToInt32(Console.ReadLine());
    if (array03[i] %2 == 0)
        summEvens += array03[i];
}
Console.WriteLine($"Сумма всех четных элементов массива = {summEvens}");

// Упражнение 4
// Напишите программу, в которой создается массив numbers1 из 5 элементов и инициализируется 
// некоторыми значениями. Также в программе создается второй массив numbers2 из трех элементов. Затем 
// все значения из массива numbers1, начиная с третьего элемента копируются в массив numbers2.
int[] numbers1 = {5, 7, 9, 2, 4};
int[] numbers2 = new int[3];
int lengthArray = numbers1.Length;
for (int i = 2; i < lengthArray; i++)
{
    numbers2[i-2] = numbers1[i];
}

for (int i = 0; i < numbers2.Length; i++)
{
    Console.Write(numbers2[i] +" ");
}

// Упражнение 5
// В одномерном массиве найти сумму элементов, находящихся между минимальным и 
// максимальным элементами. Сами минимальный и максимальный элементы в сумму не включать.

Console.WriteLine();
int[] arrayRandom = new int[5];
int k = 0;
int lengthArrayRandom = arrayRandom.Length;
Console.Write("Массив: ");
while (k < lengthArrayRandom)
{
    arrayRandom[k] = new Random().Next(0,10);
    Console.Write(arrayRandom[k]+ " ");
    k++;
}
// arrayRandom = {0,0,0,1,2,3,9,9,9,9};
int minElement = arrayRandom[0];
int maxElement = arrayRandom[0];
int minIndex = 0;
int maxIndex = 0;

for (int i = 0; i < lengthArrayRandom; i++)
{
    if (arrayRandom[i] > maxElement)
    {
        maxElement = arrayRandom[i];
        maxIndex = i;
    }

    if (arrayRandom[i] < minElement)
    {
        minElement = arrayRandom[i];
        minIndex = i;
    }
}

int summ = 0;
int start = 0;
int finish = 0;

if (Math.Abs(minIndex - maxIndex) >= 2)
{
    if (minIndex > maxIndex)
    {
        start = maxIndex;
        finish = minIndex;
    }
    else 
    {
        finish = maxIndex;
        start = minIndex;        
    }

    for (int i = start + 1; i < finish; i++)
    {
        summ += arrayRandom[i];
    }
    Console.WriteLine($"Между минимальным [{minIndex}] = {minElement} и максимальным [{maxIndex}] = {maxElement} элементами {Math.Abs(minIndex - maxIndex) - 1} элемент(а,ов) для суммирования.");
}
else 
{
    Console.Write("Между минимальным и максимальным элементами нет элементов для суммирования.");
}

Console.Write($" Сумма ={summ}");
Console.WriteLine();