int count = 0, friend = 2;
double distance, firstFriendSpeed, SecondFriendSpeed, dogSpeed, time;

distance = 10000;
firstFriendSpeed = 1;
SecondFriendSpeed = 2;
dogSpeed = 5;

/*
Console.Write("Расстояние (м): "); 
distance = double.Parse (Console.ReadLine());
    // Как парсить (или проверять) чтобы разделитель был , а не .
*/

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else 
    {
        time = distance / (SecondFriendSpeed + dogSpeed);
        friend = 1;    
    }

    distance = distance - (firstFriendSpeed + SecondFriendSpeed) * time;
    count++;
}

Console.Clear();
Console.WriteLine ("Собака пробежит " +count+ " раз");
