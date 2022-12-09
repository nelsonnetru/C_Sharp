// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    
float EnteryData (string strIntro, string strVarName)
{
	Console.Write(strIntro + " " + strVarName + ": ");
	float variable = (float)Convert.ToDouble(Console.ReadLine());
	return variable;
}
  
void Equation (float[,] vars, out float pointX, out float pointY)
{
	pointX = (vars[1, 0] - vars[0, 0]) / (vars[0, 1] - vars[1, 1]);
	pointY = vars[0, 0] + vars[0, 1] * (vars[1, 0] - vars[0, 0]) / (vars[0, 1] - vars[1, 1]);
}

Console.Clear();

float[,] variables = new float[2, 2];
string[,] namesVariables = {{"b1", "k1"}, {"b2", "k2"}}; // [00, 01] [10, 11]
    
for (int i = 0; i < variables.GetLength(0); i++)
{
	for (int j = 0; j < variables.GetLength(1); j++)
	{
		variables[i,j] = EnteryData($"Введите значение", namesVariables[i,j]);            
	}
}
    
Equation (variables, out float pointX, out float pointY);
Console.Write("Для двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 ");
Console.WriteLine($"точка пересечения: ({pointX}; {pointY})");
