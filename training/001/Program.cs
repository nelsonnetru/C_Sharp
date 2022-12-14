// Запись в файл
// StreamWriter fName = new StreamWriter("output.txt");
// for (int i = 0; i < 10; i++)
// {
//     fName.WriteLine($"Это {i} строка");
// }

// fName.Close();

// StreamReader fNameRead = new StreamReader("output.txt");
// string buf = "start";
// while (buf != String.Empty)
// {
//     buf = fNameRead.ReadLine();
//     System.Console.WriteLine(buf);
// }
// fNameRead.Close();

try
{
    System.Console.WriteLine("Пробуем делить на 0, введите 0: ");
    int n = int.Parse(Console.ReadLine());
    int b = 10/n; 
}
catch (DivideByZeroException err)
{
    System.Console.WriteLine("Ошибка! Деление на 0");
    System.Console.WriteLine($"Стандартное сообщение: {err.Message}");

}