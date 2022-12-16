// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int EnterDataNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FillRandomIntArrayUniq(int[,,] array, int leftRange, int rightRange)
{
    Random rand = new Random();
    int sizeForUniqElements = array.GetLength(0) * array.GetLength(1) * array.GetLength(2);
    int[] uniqElements = new int[sizeForUniqElements]; // тут будем хранить сгенерированные рандомные элементы, чтобы проверять на уникальность
    int counterUniqElements = 0;

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int randTmp = rand.Next(leftRange, rightRange + 1);

                while (Array.IndexOf(uniqElements, randTmp) >= 0)
                    randTmp = rand.Next(leftRange, rightRange + 1);

                array[i, j, k] = randTmp;
                uniqElements[counterUniqElements] = randTmp;
                counterUniqElements++;
            }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) \t");
        
            Console.WriteLine();
        }
}

Console.Clear();

const int leftRangeRandom = 10;
const int rightRangeRandom = 99;

int sizeM = EnterDataNumber("Введите размер m для 3-х мерного массива: ");
int sizeN = EnterDataNumber("Введите размер n для 3-х мерного массива: ");
int sizeK = EnterDataNumber("Введите размер k для 3-х мерного массива: ");

int[,,] myArray = new int[sizeM, sizeN, sizeK];
FillRandomIntArrayUniq(
        array: myArray,
        leftRange: leftRangeRandom,
        rightRange: rightRangeRandom
        );

PrintArray(myArray);