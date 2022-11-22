Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ( (number >= 100) && (number <= 999) )
{
    int last = number%10;
    Console.WriteLine(last);
}
else
{
    Console.WriteLine("Число должно быть трехзначным!");    
}

