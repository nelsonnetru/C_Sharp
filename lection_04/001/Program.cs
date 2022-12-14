// Двумерные массивы
// первое число это строки

void PrintArray (int[,]table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            System.Console.Write(table[i,j] + " ");
        }
        System.Console.WriteLine();
    }    
}

void FillArray (int[,]table)
{
    Random rand = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i,j] = rand.Next(0,10);
        }
    }    
}

System.Console.Clear();
int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);