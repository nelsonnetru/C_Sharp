Console.Clear();
int randomDigit = new Random().Next(100, 1000); // Случайное число от 100 до 999
Console.WriteLine("Случайное число: " +randomDigit);

int resultOneLine = ((randomDigit/100)*10+(randomDigit%10));
Console.WriteLine("Число: " +resultOneLine);

int pos1 = randomDigit / 100; 
Console.WriteLine("Первая цифра: " +pos1);

int pos3 = randomDigit%10; // остаток от деления на 10
Console.WriteLine("Последняя цифра: " +pos3);

int result = pos1*10 + pos3;

Console.WriteLine("Число: " +result);