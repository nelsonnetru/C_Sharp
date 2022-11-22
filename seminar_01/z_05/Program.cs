Console.Clear();
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int antiN = -N; 

if (N > 0)
{
    while (antiN <= N)
        {
            Console.WriteLine(antiN);
            antiN++;
        }
}
else
{
    while (N <= antiN)
        {
            Console.WriteLine(antiN);
            antiN--;
        }
}