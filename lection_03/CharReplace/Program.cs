string str = "Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.";

Console.Clear();

string CharReplace (string str, char find, char replace)
{
	string result = String.Empty;
	int length = str.Length;
	
	for (int i = 0; i < length; i++)
	{
		if (str[i] == find) result += $"{replace}";
		else result += $"{str[i]}";
	}

	return result;
}

Console.WriteLine(str);
string newString = CharReplace(str: str, find:  ' ', replace: '|');
Console.WriteLine(newString);