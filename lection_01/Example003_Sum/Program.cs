int numberA = new Random().Next(1,10); //Случайное число 0, 1, 2, 3 ...9
Console.WriteLine(numberA);
int numberB = new Random().Next(1,10);
Console.WriteLine(numberB);
Console.WriteLine(numberA + numberB);

int result = numberA + numberB;
Console.WriteLine("Результат " + result);